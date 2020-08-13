using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    [SerializeField]
    private Vector3 movementVector;
    bool isHit = false;
     
  

    void Update()
    {
        if (isHit == true)
        {
            transform.Translate(0, 0, 0);
        }
        else
        {
            transform.Translate(movementVector);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trigger")
        {
            isHit = true;
        }
    }


}
