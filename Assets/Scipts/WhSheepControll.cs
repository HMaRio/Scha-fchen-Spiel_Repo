using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhSheepControll : MonoBehaviour {


	// Use this for initialization
	void Start () {

		//Rigidbody rgbd; 

		
	}
	
	// Update is called once per frame
	void Update () {

		sheepMove ();
		
	}

	public void sheepMove(){

		//Vector2 sheep = this.transform.position;

		transform.Translate(Vector2.left * 0.1f * Time.deltaTime);
	}
}
