using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Y : MonoBehaviour
{
    float rotationSpeed = 2f;



    void OnMouseDrag()
    {
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        gameObject.transform.Rotate(Vector3.right, YaxisRotation, Space.World);
    }
}
