using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour {

	//Checks to see if the player has fallen past a certain point and restarts if they have.
	//This could also be used to deducted lives if required.
	public bool isDead;

	// Use this for initialization
	void Start () {
		isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -15) {
			isDead = true;
		}
		if (isDead == true) {
			StartCoroutine ("Death");
		}


	}
	IEnumerator Death (){
		SceneManager.LoadScene("ProtoTypeScene");
		yield return null;
	}

}
