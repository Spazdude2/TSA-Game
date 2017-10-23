﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour 
{
	public float JumpPower;
	float SetJumpPower;
	public int jumps;
	int SetJumps;

	Rigidbody rb;

	GameObject Player;
	// Use this for initialization
	void Start () 
	{
		Player = this.transform.gameObject;
		rb = this.GetComponent<Rigidbody> ();
		SetJumps = jumps;
		SetJumpPower = JumpPower;
	}

	// Update is called once per frame
	void Update ()
	{
		if (jumps > 0) 
		{
			if (Input.GetButtonDown ("Jump")) 
			{
				jumps--;
				rb.GetComponent<Rigidbody> ().AddForce (0, JumpPower, 0);
			}
		}
	}

	void OnCollisionEnter (Collision collision)
	{
		jumps = SetJumps;
		JumpPower = SetJumpPower;
	}

	void OnCollisionExit (Collision Collision)
	{
		JumpPower = JumpPower * 2;
	}
}