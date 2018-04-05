using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	//We want to be able to programatically access the RigidBody attributes to do this we need to first make
	//A reference to it then call it in the Start method, if we don't we can't make changes to the RigidBody
	//Attributes... This works for basically any Component from MonoBehaviour (Which most do)
	Rigidbody rb;

	//We need to add a reference for the playerInput, we add it here because it give us additional freedom not
	//Adding it to the ball or the player directly... 
	//We also need intialise it in the Start methos
	PlayerInput input;

	//Cached VAriables
	Vector3 startPos;
	float lowestAllowedY = -5f;

	[Header("Settings")]
	public float accel;
	public float maxVelocity = 10f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		input = gameObject.AddComponent<PlayerInput> ();
		startPos = transform.position;
	}

	void Update()
	{
		if (transform.position.y < lowestAllowedY)
			ResetBall ();
	}
	//Updates every physic step, whereas Update() is every frame, not all frame rates are the same, but physic
	//are... So use this instead of Update()
	void FixedUpdate(){
		Vector3 direction = input.Direction();
		//Debug.Log ("User direction = " + direction);

		Vector3 newVelocity = rb.velocity;
		newVelocity.x += direction.x * Time.fixedDeltaTime * accel;
		newVelocity.z += direction.z * Time.fixedDeltaTime * accel;
		//newVelocity.y += direction.y * Time.fixedDeltaTime * accel;

		//Clamps the max Velocity, or speed...
		newVelocity.x = Mathf.Clamp (newVelocity.x, -maxVelocity, maxVelocity);
		newVelocity.z = Mathf.Clamp (newVelocity.z, -maxVelocity, maxVelocity);

		rb.velocity = newVelocity;
		
	}

	void ResetBall()
	{
		transform.position = startPos;
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
	}

}

