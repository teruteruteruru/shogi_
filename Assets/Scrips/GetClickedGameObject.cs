using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GetClickedGameObject : MonoBehaviour
{

   public GameObject clickedGameObject;


    void Update()
    {
        clickedGameObject = GameObject.Find("Enpty");
        
        if (Input.GetMouseButtonDown(0))
        {

            

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);


            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
            }

            
        }
    }
}