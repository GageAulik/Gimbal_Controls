using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectYX : MonoBehaviour
{
    float rotationSpeed = 2f;


    void OnMouseDrag()
    {
        

        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        float ZaxisRotation = Input.GetAxis("Mouse Z") * rotationSpeed;

        gameObject.transform.Rotate(Vector3.down, XaxisRotation, Space.World);
        gameObject.transform.Rotate(Vector3.right, YaxisRotation, Space.World);
        gameObject.transform.Rotate(Vector3.up, ZaxisRotation, Space.World);
    }


  
}
