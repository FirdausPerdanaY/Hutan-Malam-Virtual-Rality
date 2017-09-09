using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour {

	private int n;
	public GameObject[] menu;
	public GameObject next1;
	public GameObject prev;
	public static int lev=0;

	private GvrViewer gr;

	AsyncOperation sync;
	public GameObject loadstat;


	public GameObject pointer;

	// Use this for initialization
	void Start () {
		n = menu.Length;

		gr = new GvrViewer ();

		gr.Recenter();



	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Exit()
	{
		Application.Quit ();
	}

	public void Prev(){

		if (menu [0].activeInHierarchy == true) {
			prev.SetActive (false);

		}
		else {
			for(int i =0;i<n;i++)
			{
				
				if (menu [i].activeInHierarchy == true) {
					menu [i - 1].SetActive (true);
					menu [i].SetActive (false);
				}
			}
			if (menu [0].activeInHierarchy == true) {
				prev.SetActive (false);
			}
			next1.SetActive (true);
		}


	}

	public void Next()
	{

	 if (menu [n-1].activeInHierarchy == true)
			next1.SetActive (false);
		else {
			for(int i=n-1;i>=0;i--)
			{
				
				if (menu [i].activeInHierarchy == true) {
					menu [i+1].SetActive (true);
					menu [i].SetActive (false);


				}
			}
			if (menu [n-1].activeInHierarchy == true) {
				next1.SetActive (false);
			
			}
			prev.SetActive (true);

		}
	}

	public void Level1()
	{
		lev = 1;
		//PlayerPrefs.SetInt ("lev", 1);
		//SceneManager.LoadScene ("main");
		StartCoroutine("load");
	}

	public void Level2()
	{
		lev = 2;
		//PlayerPrefs.SetInt ("lev", 2);
		//SceneManager.LoadScene ("main");
		StartCoroutine("load");
	}

	public void Level3()
	{
		lev = 3;
		//PlayerPrefs.SetInt ("lev", 3);
		//SceneManager.LoadScene ("main");
		StartCoroutine("load");
	}

	public void Level4()
	{
		lev = 4;
		StartCoroutine("load");
	}

	IEnumerator load()
	{
		sync = SceneManager.LoadSceneAsync ("main");
		loadstat.SetActive (true);
		pointer.SetActive (false);
		yield return sync;
	}
		

}
