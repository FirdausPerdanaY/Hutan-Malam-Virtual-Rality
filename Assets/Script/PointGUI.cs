using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointGUI : MonoBehaviour {

	int total=0;
	public Text point;
	public Text target;
	int lev;

	public GameObject End;

	// Use this for initialization
	void Start ( ) {
		lev = MenuControl.lev;
		//lev = PlayerPrefs.GetInt ("lev",lev);
		target.text = "/ " + lev.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		point.text = total.ToString();
		Completed ();
	}

	public void Score(int counter){
		total += counter;
	}

	void Completed()
	{
		if (total == lev) {
			End.SetActive (true);
		}
	}
}
