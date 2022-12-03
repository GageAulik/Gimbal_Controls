using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube__Rotation_X : MonoBehaviour
{
   public GameObject GimbalX;
   public GameObject GimbalY;
   public GameObject GimbalZ;
   public GameObject CubeXYZ;
   public float sensitivity = 100f;


    void Update()
    {
        if (GimbalX)
            CubeXYZ.transform.rotation = GimbalX.transform.rotation;

        else if (GimbalY)
           CubeXYZ.transform.rotation = GimbalY.transform.rotation;

        else if (GimbalZ)
            CubeXYZ.transform.rotation = GimbalZ.transform.rotation;


    }
}

