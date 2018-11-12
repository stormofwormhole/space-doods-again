using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchBlock : MonoBehaviour {

private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("z"))
		{
			animator.SetBool(("IsDefending"), true);

		}

		 else animator.SetBool("IsDefending", false);

	}
}
