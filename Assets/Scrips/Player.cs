using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float auxInput;
    private Animator myAnimator;
   [SerializeField]
    protected string animatorFloat;
    [SerializeField]
    private float speed=2;
    [SerializeField]
    private float speedRotation=45;
    [SerializeField]
    private KeyCode runKey = KeyCode.LeftShift;
    private CharacterController myController;



    private void Awake()
    {
        myAnimator = GetComponent<Animator>();
        myController=GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        auxInput = Input.GetAxis("Vertical");


        if (Input.GetKey(runKey))
        {
            auxInput *= 3f;
        }

        myAnimator.SetFloat( animatorFloat, auxInput);
        myController.Move(transform.forward * (speed * auxInput * Time.deltaTime));
        //transform.position += transform.forward * ( speed *auxInput* Time.deltaTime);
            

        auxInput = Input.GetAxis("Horizontal");
        transform.Rotate(0f, speedRotation * auxInput * Time.deltaTime, 0f);





    }



}
