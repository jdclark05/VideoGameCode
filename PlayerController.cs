using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
	public float tilt;
	public Done_Boundary boundary;
	

	public string horizontalAxis = "Horizontal";
	public string verticalAxis = "Vertical";
	
	private Camera mainCamera;

	void Start ()
	{	
	    //null player controls during player respawn period
		if (GameObject.FindGameObjectWithTag("PlayerModel") == null)
		{
			return;
		}
    }

	
	void FixedUpdate ()
	{


		//Calculating speed and movement//

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical).normalized;

		GetComponent<Rigidbody>().velocity = movement * speed;
		
		GetComponent<Rigidbody>().position = new Vector3
		(
			//Applying boundaries to player objecct//

			Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
		);
		
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
	}


}




	

