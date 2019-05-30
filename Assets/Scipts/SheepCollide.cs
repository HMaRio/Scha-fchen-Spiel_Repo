using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepCollide : MonoBehaviour {

	public bool colide = false;

	void OnCollisionEnter (Collision col){


		if (col.gameObject.tag =="white-sheep" ) {
			//colide = true;

			ActivateMove active_sheep = col.gameObject.GetComponent<ActivateMove> ();

			active_sheep.enabled = !active_sheep.enabled;

			//print (col.gameObject.name);
		}
	} 

}
