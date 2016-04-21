﻿using UnityEngine;
using System.Collections;

public class Door3 : MonoBehaviour {
	public bool Slide;	// Reference to the animator bool to trigger the state.

	private Animator anim;		// Reference to the animator component.
	private GameObject player;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		anim = GetComponent<Animator>();
	}

	void OnTriggerEnter (Collider other){
		anim.SetBool("slide", true);
			}

	void OnTriggerExit (Collider other){
		anim.SetBool("slide", false);
	}
}
