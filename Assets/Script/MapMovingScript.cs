using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovingScript : MonoBehaviour {

	private int obj=0;

	static int lev;

	public Transform bottom;

	//public float ex;
	//public float ye;

	public GameObject[] objective;
	public Transform[] logObject;

	public Transform trackedObject;
	public Transform miniMapObject;

	public Transform baseOrig;
	public Transform boundOrig;
	public Transform boundmini;

	public Transform edgeMiniMap;

	private float lenghtXOriginal;
	private float lenghtZOriginal;

	private float lenghtXMiniMap;
	private float lenghtYMiniMap;

	private float ratioX;
	private float ratioZ;

	private float positionX;
	private float positionY;

	private Transform newPositionMap;

	// Use this for initialization
	void Start () {

		lenghtXOriginal = Mathf.Abs (boundOrig.position.x-baseOrig.position.x);
		lenghtZOriginal = Mathf.Abs(boundOrig.position.z-baseOrig.position.z);

		lenghtXMiniMap = Mathf.Abs (boundmini.localPosition.x-edgeMiniMap.localPosition.x);
		lenghtYMiniMap = Mathf.Abs(boundmini.localPosition.y-edgeMiniMap.localPosition.y);

		/*
		lenghtXOriginal = Vector3.Distance (baseOrig.position, boundOrigX.position);
		lenghtZOriginal = Vector3.Distance (baseOrig.position, boundOrigZ.position);

		lenghtXMiniMap = Vector3.Distance (edge.position, boundminiX.position);
		lenghtYMiniMap = Vector3.Distance (edge.position, boundminiY.position);
		*/
		ratioX = (lenghtXMiniMap / lenghtXOriginal);
		ratioZ = (lenghtYMiniMap / lenghtZOriginal);


		for(int i=0;i<logObject.Length;i++)
		{

			float positionLogX=Mathf.Abs(logObject[i].position.x-baseOrig.position.x);
			float positionLogY=Mathf.Abs(logObject[i].position.z-baseOrig.position.z);

			Vector2 newPositionObj = new Vector2 ();

			newPositionObj.x = (ratioX * positionLogX)+bottom.localPosition.x;
			newPositionObj.y = (ratioZ * positionLogY)+bottom.localPosition.y;

			objective[i].transform.localPosition= newPositionObj;
		}
		objective [0].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
		 positionX=Mathf.Abs(trackedObject.position.x-baseOrig.position.x);
		 positionY=Mathf.Abs(trackedObject.position.z-baseOrig.position.z);

		Vector2 newPositionMap = new Vector2 ();

		newPositionMap.x = (ratioX * positionX)+bottom.localPosition.x;
		newPositionMap.y = (ratioZ * positionY)+bottom.localPosition.y;

		miniMapObject.localPosition= newPositionMap;

	}

	public void MapObjective(int count)
	{
		obj=obj+count;
		lev = MenuControl.lev;
		Destroy(objective [obj - 1]);
		if(obj<lev) 
		{
		objective [obj].SetActive (true);
		}

	}

}
