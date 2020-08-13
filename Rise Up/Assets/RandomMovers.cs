using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovers : MonoBehaviour
{

    public float minX = -0.05f;
    public float maxX = 0.05f;
    public float minZ = -0.05f;
    public float maxZ = 0.05f;


    // Start is called before the first frame update
 
    private void Update()
    {
        float newX = Random.Range(minX, maxX);
        float newZ = Random.Range(minZ, maxZ);
        Vector3 myVector = new Vector3(newX, 0, newZ);


        transform.Translate(myVector);
    }
}
