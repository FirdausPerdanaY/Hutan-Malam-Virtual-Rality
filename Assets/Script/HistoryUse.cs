using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HistoryUse : MonoBehaviour {

	public Text histo;
	// Use this for initialization
	void Start () {
		histo.text=PlayerPrefs.GetString ("history");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
