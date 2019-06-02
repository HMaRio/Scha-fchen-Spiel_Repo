using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

	private ShController sheepController;

	// Use this for initialization
	void Start () {
		sheepController = GetComponent<ShController> ();
	}
	
	// Update is called once per frame
	void Update () {

		Touch touch = Input.GetTouch (0);

		if (Input.touchCount > 0 || touch.deltaTime > 200f)  {

//Tochinput controlling
//
//			Vector3 touch_Pos = Camera.main.ScreenToWorldPoint (touch.position);
//
//
//
//			if (touch_Pos.x > 0) {
//				sheepController.MoveRight ();
//			}
//			else if (touch_Pos.x < 0) {
//				sheepController.MoveLeft ();
//					
//			} 
//
//			if (touch_Pos.y > 0) {
//				sheepController.MoveUp ();
//			}
//			else if (touch_Pos.y < 0) {
//				sheepController.MoveDown ();
//
//			} 

			//move object to touch position
//			else  if (touch.phase = TouchPhase.Began) // if long touch 
			{
				// do stuff. 

				// If you want to detect long press on an object, do the following.


				Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);
				GameObject sheep = GameObject.FindGameObjectWithTag ("black-sheep");
				sheep.transform.position = new Vector3 (pos.x, pos.y, 1.8f);

							
			}

		}
	}
}
