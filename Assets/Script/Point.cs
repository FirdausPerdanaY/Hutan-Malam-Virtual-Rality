using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {


	PointGUI hud;
	LevelCat level;
	MapMovingScript map;

	GameObject [] MapItem;

	int lev;
	// Use this for initialization
	void Start () {
		lev = PlayerPrefs.GetInt ("lev",lev);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			
			hud = GameObject.Find ("Capsule").GetComponent<PointGUI> ();
			level = GameObject.Find ("Capsule").GetComponent<LevelCat> ();

			map = GameObject.Find ("Capsule").GetComponentInChildren<MapMovingScript> ();

		
			hud.Score (1);
			Destroy (this.gameObject);
			level.SetActive (1);
			map.MapObjective (1);
		}

	}
}
