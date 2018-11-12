using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour {

public CharacterController2D controller;

public float runSpeed = 40f;

float horizontalMove = 0f;

	
	// Update is called once per frame
	void Update () {
		
horizontalMove = Input.GetAxisRaw("Horizontal1") * runSpeed;  

	}

	void FixedUpdate ()

	{
// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
	}
}
