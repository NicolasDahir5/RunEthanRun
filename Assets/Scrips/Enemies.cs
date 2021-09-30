using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public int rutine; 
    public float chronometer;
    public Animator animator;
    public Quaternion angle;
    public float grade;

    public GameObject target;
    public bool atack;
    
    
    void Start()
    {
        animator = GetComponent<Animator>();
        target = GameObject.Find("Ethan");
    }
    
    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 5)
        {
            animator.SetBool("run", false);
            chronometer += 1 * Time.deltaTime;
            if (chronometer >= 4)
            {
                rutine = Random.Range(0, 2);
                chronometer = 0;

            }
            switch (rutine)
            {
                case 0:
                    animator.SetBool("walk", false);
                    break;

                case 1:
                    grade = Random.Range(0, 360);
                    angle = Quaternion.Euler(0, grade, 0);
                    rutine++;

                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angle, 0.5f);
                    transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                    animator.SetBool("walk", true);

                    break;

            }
        }
        else
        {
            if (Vector3.Distance(transform.position, target.transform.position)> 1 && !atack)
            {


                var looksPos = target.transform.position - transform.position;
                looksPos.y = 0;
                var rotation = Quaternion.LookRotation(looksPos);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
                animator.SetBool("walk", false);

                animator.SetBool("run", true);
                transform.Translate(Vector3.forward * 2 * Time.deltaTime);

                //animator.SetBool("attack", false);
            }
            else
            {
                animator.SetBool("walk", false);
                //animator.SetBool("run,", false);

                animator.SetBool("atack", true);
                atack = true;
            }
        }


    }
   public void Final_Ani()
    {
        animator.SetBool("atack", false);
        atack = false;
    }
    void Update()
    {
        Comportamiento_Enemigo();
    }
}
