using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Z : MonoBehaviour
{
    float rotationSpeed = 2f;



    void OnMouseDrag()
    {
        float ZaxisRotation = Input.GetAxis("Horizontal") * rotationSpeed;

        gameObject.transform.Rotate(Vector3.up, ZaxisRotation, Space.World);
    }

void Update()
    {
    }
}
