using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderContoller : MonoBehaviour
{

  
    [SerializeField]
    private float distance;
    private Vector2 lastMousePos;
    public float cylinderSpeed;
    [SerializeField]
    private float speed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);

        Vector2 deltaPos = Vector2.zero;
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePosCurrent = Input.mousePosition;
            if (lastMousePos == Vector2.zero)

                lastMousePos = mousePosCurrent;
            deltaPos = mousePosCurrent-lastMousePos;

            lastMousePos = mousePosCurrent;
            Vector3 force = new Vector3(deltaPos.x, 0,deltaPos.y);
            transform.Translate(force*cylinderSpeed,Space.World);

        }
        else
        {
            lastMousePos = Vector2.zero;
        }
        





    }
    private void LateUpdate()
    {
        Vector3 pos = transform.position;
        if (transform.position.z < Camera.main.transform.position.z + distance)
        {
            pos.x = distance;
        }
    }
}
