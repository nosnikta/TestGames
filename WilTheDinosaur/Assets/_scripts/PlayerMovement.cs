using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	//Creates Vairables to control users Speed and Jumping height
	public int playerSpeed = 5;
	public int playerJump = 500;
	private float movementX;

	//var isgrounded : boolean = true;

	bool isGrounded;

	// Use this for initialization
	void Start () {
	}


	// Update is called once per frame
	//Calls the MovePlayer Method every updated frame
	void Update () {
		MovePlayer ();


	}
		
	//Checks for the imput from the Spacebar and the Horizontal arrows and make the character Jump and run 
	void MovePlayer() {
		if (Input.GetButtonDown ("Jump")) {
			Jump ();
		}
		movementX = Input.GetAxis ("Horizontal");
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (movementX * playerSpeed, gameObject.GetComponent<Rigidbody2D> ().velocity.y);

	}

	//Method to do the jumping
	void Jump(){
		GetComponent<Rigidbody2D> ().AddForce (Vector2.up * playerJump);
	}
		
}
