using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagment : MonoBehaviour
{

   public Vector3 offset = new Vector3(0, 15, 0);
    [SerializeField]
    private Transform baloon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,(baloon.transform.position + offset), 1.0f);
    }
}
