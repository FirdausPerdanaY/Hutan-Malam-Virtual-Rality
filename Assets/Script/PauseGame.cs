using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {

	int lev;
	public GameObject pauseMenu;
	public bool trigger =false,menuPause=false;
	string ends;

	// Use this for initialization
	void Start () {
		lev=MenuControl.lev;

	}
	
	// Update is called once per frame
	void Update () {
		TimeDuration time = GetComponent<TimeDuration> ();

		if (Input.GetButtonDown ("Fire2") && trigger == false && menuPause == false) {
			Time.timeScale = 0;
			pauseMenu.SetActive (true);
			menuPause = true;
		} else if (Input.GetButtonDown ("Fire1") && trigger == false && menuPause == true) {
			
			PlayerPrefs.SetString("history","Tingkat "+lev+"\n"+time.timetext);
			Time.timeScale = 1;
			SceneManager.LoadScene ("menu");
		}
		
		else if (Input.GetButtonDown("Fire2") && trigger == false && menuPause==true){
			Time.timeScale = 1;
			pauseMenu.SetActive (false);
			menuPause = false;

		}

	}


}
