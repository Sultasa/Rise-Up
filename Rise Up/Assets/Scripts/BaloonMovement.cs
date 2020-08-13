using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private GameObject gamePanel;
   public GameObject[] walkers;
    public GameObject[] movingWalls;

    
   

   

    void FixedUpdate()
    {
        transform.Translate(0, 0, speed);
    }

    private void OnCollisionEnter(Collision cube)
    {
        if (cube.collider.tag == "Enemy")
        {
            gameObject.SetActive(false);

            gamePanel.SetActive(true);

        }
      

     
    }
    private void OnTriggerEnter(Collider wall)
    {
        if (wall.tag == "wall")
        {
            
        
            for (int i = 0; i < walkers.Length; i++)
            {
                walkers[i].SetActive(true);
                Debug.Log(walkers);
            }
        }
        if (wall.tag == "Wall1")
        {
            for (int i = 0; i < movingWalls.Length; i++)
            {
                movingWalls[i].SetActive(true);


            }
        }
    }
}
  
