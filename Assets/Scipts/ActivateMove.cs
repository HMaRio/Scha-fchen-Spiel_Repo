using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMove : MonoBehaviour {

	private Rigidbody rgbd;
	public float speed;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		//rgbd = GetComponent<Rigidbody> ();
		anim.Play("Idle-le");
	}
	// Update is called once per frame
	void Update () {

		//float moveHorizontal = Input.GetAxis ("Horizontal");

		//Vector2 move = new Vector2 (Vector2.right * speed * Time.deltaTime, 0);
		//
		//transform.position = move;

		transform.Translate (-Vector2.right * 1f * Time.deltaTime);
		anim.Play ("Walk-le");

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		//rgbd.AddForce (move * speed);
	}

		void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "border") {

			Destroy(this.gameObject);
			
			}

	}
}
