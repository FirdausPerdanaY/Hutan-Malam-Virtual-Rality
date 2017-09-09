using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimation : MonoBehaviour {

	Animator anima;
	//Animation anim;
	// Use this for initialization
	void Start () {
		anima = GetComponent<Animator> ();


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Vertical") != 0 || Input.GetAxis ("Horizontal") != 0) {
			anima.Play ("Walk");
		} else
			anima.Play ("Idle");
	}
}
