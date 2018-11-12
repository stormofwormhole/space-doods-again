using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick_Defense : MonoBehaviour {

private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Joystick1Button4))
		{
			animator.SetBool(("IsKickDefending"), true);

		}

		 else animator.SetBool("IsKickDefending", false);

	}
}
