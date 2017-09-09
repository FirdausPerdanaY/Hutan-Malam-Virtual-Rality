using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEnabler : MonoBehaviour {

	public bool trigger=false,menuPause=false;

	public GameObject Map;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PauseGame pause = GetComponent<PauseGame> ();


		if (Input.GetButtonDown ("Fire1")==true && Map.activeSelf==false && trigger==false && pause.menuPause==false) {
			Map.SetActive (true);
		} else if(Input.GetButtonDown ("Fire1")==true && Map.activeSelf==true&& trigger==false && pause.menuPause==false) {
			Map.SetActive (false);
		}
	}

}
