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

		if (Input.touchCount > 0) {

			Touch touch = Input.GetTouch (0);
			Vector3 touch_Pos = Camera.main.ScreenToWorldPoint (touch.position);

			if (touch_Pos.x > 0) {
				sheepController.MoveRight ();
			}
			else if (touch_Pos.x < 0) {
				sheepController.MoveLeft ();
					
			} 

			if (touch_Pos.y > 0) {
				sheepController.MoveUp ();
			}
			else if (touch_Pos.y < 0) {
				sheepController.MoveDown ();

			} 
			else {
			
			}
		}
	}
}
