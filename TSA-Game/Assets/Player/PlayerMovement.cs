﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public float SetSpeed;

	public float Speed;
	public float RunSpeed;

	// Use this for initialization
	void Start ()
	{
		SetSpeed = Speed;
		Cursor.lockState = CursorLockMode.Locked;

	}
	// Update is called once per frame
	void Update ()
	{
	    

		float MoveFB = Input.GetAxis ("Vertical") * Speed;
		float MoveLR = Input.GetAxis ("Horizontal") * Speed;
		MoveFB *= Time.deltaTime;
		MoveLR *= Time.deltaTime;

		transform.Translate (MoveLR, 0, MoveFB);

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Cursor.lockState = CursorLockMode.None;
		}
			
	}
	void OnCollisionEnter (Collision collision)
	{
		if (Input.GetKey (KeyCode.LeftShift)) 
		{
			Speed = RunSpeed;
		} 
		else 
		{
			Speed = SetSpeed;
		}

	}
		
}
