using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundClick : MonoBehaviour
{
 private AudioSource audioSource;
    public AudioClip click;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioSource.PlayOneShot(click, 0.6f);
        }
    }
}
   

   
   

