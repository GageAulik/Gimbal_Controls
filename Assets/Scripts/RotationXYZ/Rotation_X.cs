using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_X : MonoBehaviour
{
    float rotationSpeed = 2f;
   


    public void OnMouseDrag()
    {


        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;


        gameObject.transform.Rotate(Vector3.down, XaxisRotation, Space.World);

    }

}
