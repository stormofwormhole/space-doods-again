using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchBlock1 : MonoBehaviour {

private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Joystick2Button5))
		{
			animator.SetBool(("IsDefending"), true);

		}

		 else animator.SetBool("IsDefending", false);

	}
}
