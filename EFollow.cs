using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EFollow : MonoBehaviour
{
   public float speed;
    public float tilt;


    private Transform target;


    void Start ()
    {
    	target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update()
    {

    	transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void FixedUpdate ()
    {

    float moveHorizontal = Input.GetAxis ("Horizontal");
    float moveVertical = Input.GetAxis ("Vertical");

    Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
    movement = movement.normalized * Time.deltaTime;
    GetComponent<Rigidbody>().velocity = movement * speed;

       GetComponent<Rigidbody>().position = new Vector3 
        (
            Mathf.Clamp (GetComponent<Rigidbody>().position.x, -29.8f, 29.8f), 
            0.0f, 
            Mathf.Clamp (GetComponent<Rigidbody>().position.z, -20.5f, 20.4f)
        );


    GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * tilt);

            if (movement != Vector3.zero)
                 {
                    transform.rotation = Quaternion.LookRotation(movement);
                 }

            transform.Translate (movement * speed * Time.deltaTime, Space.World);



    }

}
