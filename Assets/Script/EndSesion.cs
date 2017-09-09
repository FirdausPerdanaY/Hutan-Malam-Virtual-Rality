using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSesion : MonoBehaviour {

	public GameObject[] hide;
	public GameObject show,map;

	int lev;

	public bool trigger= false;

	GameObject terrain,temp,player;

	AudioSource audi;

	// Use this for initialization
	void Start () {
		audi=GetComponent<AudioSource>();
		lev = MenuControl.lev;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") == true && trigger==true) {
			SceneManager.LoadScene ("menu");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		trigger = true;
		player= GameObject.FindGameObjectWithTag("Player");


		terrain = GameObject.FindGameObjectWithTag("Terrain");
		AudioSource [] ter = terrain.GetComponents<AudioSource> ();
		Walk temp = other.GetComponent<Walk> ();
		MapEnabler mup = player.GetComponent<MapEnabler> ();
		TimeDuration time = player.GetComponent<TimeDuration> ();
		PauseGame pause = player.GetComponent<PauseGame> ();

		if (other.gameObject.tag == "Player") {

			PlayerPrefs.SetString("history","Tingkat "+lev+"\n"+time.timetext);

			mup.trigger = true;
			pause.trigger = true;
			//Destroy (map);
			for (int i=0;i<ter.Length;i++)
			{
				ter [i].Stop ();
			}


			temp.speed=0;

			for (int i = 0; i < hide.Length; i++) {
				hide [i].SetActive (false);
			}
			show.SetActive ( true);
			audi.Play ();

		}

	}

}
