using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
      public GameObject follow;
      public float cameraHeight;
      public float xMin, xMax, zMin, zMax;
  
      void Update() 
      {
          Vector3 pos = follow.transform.position;
          pos.y += cameraHeight;
          transform.position = pos;

      }
  

       void FixedUpdate ()
       {
       	float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement;

          GetComponent<Rigidbody>().position = new Vector3 
          (
            Mathf.Clamp (GetComponent<Rigidbody>().position.x, -8f, 8f), 
            10.0f, 
            Mathf.Clamp (GetComponent<Rigidbody>().position.z, -8.15f, 8.15f)
          );

      	}

}
