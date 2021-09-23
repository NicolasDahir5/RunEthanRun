using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraThirdperson : MonoBehaviour
{
    public Vector3 offsett;
    [SerializeField]
    private Transform target;
    public float lerpValue;
    public float sensibility;

    
    
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offsett, lerpValue);
        offsett = Quaternion.AngleAxis(Input.GetAxis("Mouse X")*sensibility,Vector3.up)*offsett;
        transform.LookAt(target);

    }
}
