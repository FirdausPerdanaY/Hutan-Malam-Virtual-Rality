using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour {

	public Vector3 NorthDirection;
	public Transform Player;
	public Quaternion Direction;

//	public RectTransform NorthLayer;
	public RectTransform MissionLayer;

	public Transform MissionPlace;

	
	// Update is called once per frame
	void Update () {
		ChangeNorthDir ();
		ChangeDir ();
	}

	void ChangeNorthDir()
	{
		NorthDirection.z = Player.eulerAngles.y;
		//NorthLayer.localEulerAngles = NorthDirection;
	}

	void ChangeDir()
	{
		Vector3 dir =  MissionPlace.position-transform.position ;
		Direction = Quaternion.LookRotation (dir);
		Direction.z = Direction.y;
		Direction.x = 0;
		Direction.y = 0;

		MissionLayer.localRotation = Direction * Quaternion.Euler (NorthDirection);
	}
}
