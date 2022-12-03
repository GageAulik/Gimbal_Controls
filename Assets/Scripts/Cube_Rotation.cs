using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Rotation_X : MonoBehaviour
{
    public GameObject GimbalX;
    public GameObject GimbalY;


    void Update()
    {
        transform.rotation = GimbalX.transform.rotation;
        transform.rotation = GimbalY.transform.rotation;
    }
}
