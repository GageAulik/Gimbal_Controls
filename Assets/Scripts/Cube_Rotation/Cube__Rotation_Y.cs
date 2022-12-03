using UnityEngine;

public class Cube__Rotation_Y : MonoBehaviour
{
    public GameObject GimbalY;


    void Update()
    {
        transform.rotation = GimbalY.transform.rotation;

    }
}