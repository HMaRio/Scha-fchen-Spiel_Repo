using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControll : MonoBehaviour {

	GameObject[] hiddings;
	GameObject startpos;

	ArrayList hide = new ArrayList();
	private int indexRandom; 

	ArrayList white_sheeps = new ArrayList();
	GameObject[] sh_inScene;

	public Text wintext;
	public Text challenge;

	public GameObject replay;

	// Use this for initialization
	void Start () {

		//int y = 0;

		wintext.text = "";
		challenge.text = "";

		replay.SetActive(false);


		hiddings = GameObject.FindGameObjectsWithTag ("hides");


		while (hide.Count <= 2) {

			indexRandom = Random.Range (0, hiddings.Length);

			if (hide.Contains (hiddings[indexRandom])) {

			} else {

				hide.Add (hiddings [indexRandom]);
			}
		}
		int i;

		for (i = 0; i <= hide.Count; i++) {

			GameObject vste = hide [i] as GameObject;

			BoxCollider vstebc = vste.GetComponent<BoxCollider> ();
			vstebc.enabled = false;

			GameObject hidepos = vste.transform.GetChild(0).gameObject;

		

			Vector2 pos = new Vector2 (hidepos.transform.position.x, hidepos.transform.position.y);

			GameObject sheep_white = Instantiate (Resources.Load("Schaf_weiß")) as GameObject;

			sheep_white.name = "Schaf_Weiß" + i;

			sheep_white.transform.position = new Vector3 (pos.x, pos.y, 2.12f);
			//Vector2 sheepposition = pos.transform.position;

			//print (vste + " : " + pos);

		}


					
	}
	
//	// Update is called once per frame
	void Update () {

		//AddingToList ();
		sh_inScene = GameObject.FindGameObjectsWithTag ("white-sheep");
		int count = sh_inScene.Length;

		if (sh_inScene.Length != 0) {

			challenge.text = "Find noch " + count + " Schaf(e)";
		}	else {
			wintext.text = "Gewonnen";
			challenge.text = "Bravo!! Du hast alle Schafe gefunden";
			replay.SetActive(true);
		
		}





	}
			
//
//	void AddingToList(){
//
//		sh_inScene = GameObject.FindGameObjectsWithTag ("white-sheep");
//
//		while (white_sheeps.Count <= 2) {
//
//			white_sheeps.Add (sh_inScene);
//		}
//			if (white_sheeps.Count == 3) {
//				Rename ();
//			} else if (white_sheeps.Count == 0) {
//				wintext.text = "Gewonnen";
//			}
//	
//	}
//		//print (white_sheeps.Count);
//		void Rename(){
//		for (int i = 0; i <= white_sheeps.Count; i++) {
//
//			//GameObject vste = white_sheeps [i] as GameObject;
//			sh_inScene[i].name = "Schaf_Weiß" + i;
//
//		}
//	}

}
