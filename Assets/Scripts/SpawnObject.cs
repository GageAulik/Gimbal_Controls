
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    //create a game object for spawning in the cube
    public GameObject whatToSpawn;

    public void ButtonClick()
    {
        SpawnObjectAtLocation(0, 0, 0);
    }
   
    private void SpawnObjectAtLocation(float posX, float posY, float posZ)
    {
        //spawns object at 0,0,0
        GameObject newObject;
        newObject = Instantiate(whatToSpawn, new Vector3(posX, posY, posZ), transform.rotation);
        //assigning the script to spawn the object in the empty object
        newObject.transform.SetParent(GameObject.Find("Canvas").transform, false);
    }
}
