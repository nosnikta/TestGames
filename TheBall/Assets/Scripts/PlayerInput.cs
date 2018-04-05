using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	//What is a Vector3? It is three FLoating Points, an X a Y and a Z..
	//The Vector3.zero is a short cut to call all the x, y, and z zero(0)..
	public Vector3 Direction() 
	{
		Vector3 newVector = Vector3.zero;

		newVector.x = Input.GetAxis ("Horizontal");
		newVector.z = Input.GetAxis ("Vertical");
		//newVector.y = Input.GetAxis ("Jump");

		return newVector;
	}
		
	
}
