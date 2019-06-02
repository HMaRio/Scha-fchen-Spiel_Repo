using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShController : MonoBehaviour {

	//Animator anim;
	public float speed; 

	//private Rigidbody2D rb2d;  
	private Animator animbl;

	// Use this for initialization
	void Start () {

		animbl = GetComponent<Animator> ();
		//rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {


		DetectInput ();

//		//	       //Store the current horizontal input in the float moveHorizontal.
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//
//		//Store the current vertical input in the float moveVertical.
//		float moveVertical = Input.GetAxis ("Vertical");
//
//		//Use the two store floats to create a new Vector2 variable movement.
//		//Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
//		Vector2 move = new Vector2 (moveVertical * speed * Time.deltaTime, moveHorizontal * speed * Time.deltaTime);
//
//		transform.position = move;

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		//rb2d.AddForce (movement * speed);

	}
	public void MoveRight() {
		transform.Translate (Vector2.right * speed * Time.deltaTime);
				//transform.eulerAngles = new Vector2 (0, 0);
		animbl.SetBool("isrunning", true);
		animbl.Play("Walk-re-bl");
	}

	public void MoveLeft() {

		transform.Translate (-Vector2.right * speed * Time.deltaTime);
				//transform.eulerAngles = new Vector2 (0, 0);
		animbl.SetBool("isrunning", true);
		animbl.Play("Walk-le-bl");
	}

	public void MoveUp() {

		transform.Translate (Vector2.up * speed * Time.deltaTime);
	}

	public void MoveDown() {
		
			transform.Translate (Vector2.down * speed * Time.deltaTime);
				
	}
	void DetectInput() {
		float x = Input.GetAxisRaw("Horizontal");


		//if (x > 0) {

		if (Input.GetKey(KeyCode.RightArrow)){
			MoveRight ();
		}else{
			animbl.SetBool("isrunning", false);
			//animbl.Play ("schaf-schwarz");
		}
		//if (x < 0) {
		if (Input.GetKey(KeyCode.LeftArrow)){
			MoveLeft ();
		}else{
			animbl.SetBool("isrunning", false);
			//animbl.Play ("schaf-schwarz-le");
		
		}

		float y = Input.GetAxisRaw ("Vertical");

		if (y > 0) {
			MoveUp ();
		}
		else if(y < 0) {
			MoveDown();
		}
		

	}
}
