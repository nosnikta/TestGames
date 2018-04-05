using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rb2d;

	//private RigidBody
	[HideInInspector]
	public bool isFacingRight = true;
	[HideInInspector]
	public bool isJumping = false;
	[HideInInspector]
	public bool isGrounded = false;

	public float jumpForce = 650.0f;
	public float maxSpeed = 7.0f;

	public Transform groundCheck;

	public LayerMask groundLayer;

	private float groundCheckRadius = 0.2f;



	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate (){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement * maxSpeed);
	}
}
