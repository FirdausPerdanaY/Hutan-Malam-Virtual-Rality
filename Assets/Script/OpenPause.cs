using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPause : MonoBehaviour {

	public bool trigger=false,buttonTrigger;

	public GameObject pauseMenu;
	// Use this for initialization
	void Start () {
		PauseGame pause = GetComponent<PauseGame> ();
		buttonTrigger = pause.trigger;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2") && trigger == false && buttonTrigger == false) {
			Time.timeScale = 0;
			pauseMenu.SetActive (true);
		} else if (Input.GetButtonDown ("Fire2") && trigger == false && buttonTrigger == true) {
			Time.timeScale = 1;
			pauseMenu.SetActive (false);
		}
	}
}
