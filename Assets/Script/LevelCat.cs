using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCat : MonoBehaviour {

	int lev;
	int maxlev=0;
	int inp=0;

	public GameObject[] GMove;
	public GameObject[] GHome;
	public GameObject[] Light;
	public GameObject[] GLv;

	// Use this for initialization
	void Start () {
		lev = MenuControl.lev;
		maxlev = lev;

		if (maxlev < 4) {
			Light [maxlev - 1].SetActive (true);
		}
		GMove [0].SetActive (true);
		if (maxlev>1)
			for(int i=0;i<maxlev-1;i++)
			{	
		GLv [i].SetActive (true);
			}

	}
	
	public void SetActive(int log)
	{
		inp = inp+log;

		if (inp < maxlev) {
			GMove [inp].SetActive (true);
			GMove [inp - 1].SetActive (false);
		}

		if (inp == maxlev) {
			if (maxlev == 2) {
				GHome [0].SetActive (true);
			}
			GHome [inp-1].SetActive (true);
			GMove [inp - 1].SetActive (false);
		}
	}
}
