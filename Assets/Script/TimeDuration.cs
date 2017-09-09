using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDuration : MonoBehaviour {

	public Text time;
	float playtime;

	public string timetext="00:00";

	float seconds;
	float minutes;

	string min;
	string sec;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		playtime = Time.timeSinceLevelLoad;
		seconds = Mathf.FloorToInt (playtime % 60);
		minutes = Mathf.FloorToInt (playtime / 60);

		if (seconds < 10) {
			sec = "0" + Mathf.RoundToInt (seconds).ToString ();
		} else if(seconds>=10 && seconds<60)
			sec = seconds.ToString ();
		
		if (minutes < 10) {
			min = "0" + minutes.ToString ();
		} if(minutes>=10 && minutes<60)
			min = minutes.ToString ();
		
		//time.text = playtime.ToString ();
		timetext = min + ":" + sec;
		time.text = timetext;

	}
}
