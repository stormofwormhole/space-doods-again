﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch1 : MonoBehaviour {

private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Joystick2Button3))
		{
			animator.SetTrigger("Punch");
		}
	}
}
