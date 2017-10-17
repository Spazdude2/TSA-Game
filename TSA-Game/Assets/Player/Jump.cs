using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour 
{
	public int jumps;
	CharacterController Player;
	public float jumpPower;
	private Vector3 jump = Vector3.zero;
	public float Gravity;
    private double speed = 0;
	// Use this for initialization
	void Start () 
	{
		Player = gameObject.GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update ()
	{
		
		if (Player.isGrounded) 
		{
			jumps = 3;
		
		}
			if (jumps > 0) 
			{
				if (Input.GetButtonDown ("Jump")) 
				{
					jumps--;
                    speed = 0;
                    jump.y = jumpPower;
				}
			}
        if (!Player.isGrounded)
            speed -= Gravity * Time.deltaTime;
        else 
            speed = 0;
        
        jump.y = jump.y + (float)speed * Time.deltaTime;
		Player.Move (jump * Time.deltaTime);
	}
}