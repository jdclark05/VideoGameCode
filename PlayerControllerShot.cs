using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerShot : MonoBehaviour
{

	
	public GameObject shot;
	

	private string horizontalAxis2 = "Horizontal2";
	private string verticalAxis2 = "Vertical2";
	private bool canShoot = true;

    /*
    float shootHorizontal = Input.GetAxis("Horizontal2");
	float shootVertical = Input.GetAxis("Vertical2");
    */






	void Update()
	{

		if (GameObject.FindGameObjectWithTag("PlayerModel") == null)
		{
			return;
		}
        

	}

	void FixedUpdate ()
	{
		

		Vector3 shootDirection = Vector3.right*Input.GetAxis(horizontalAxis2) + Vector3.forward*Input.GetAxis(verticalAxis2);
		if(canShoot && shootDirection.sqrMagnitude > 0.3f)
		{
			transform.rotation = Quaternion.LookRotation(shootDirection,Vector3.up);
			Instantiate(shot,transform.position,transform.rotation);


        }
		      
	
	}


}
