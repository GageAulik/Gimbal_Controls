using UnityEngine;

public class Cube__Rotation_Z : MonoBehaviour
{
    public GameObject GimbalZ;


    void Update()
    {
        transform.rotation = GimbalZ.transform.rotation;
    }
}
