using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {


	public float speed;
	public GameObject head;
	private Vector3 movedir=Vector3.zero;

	[SerializeField] private AudioClip[] m_FootstepSounds;    
	private AudioSource m_AudioSource;

	private float m_StepCycle;
	private float m_NextStep;

	private GvrViewer gr;

	// Use this for initialization
	void Start () {

		gr = new GvrViewer ();
		gr.Recenter();

		Cursor.lockState = CursorLockMode.Locked;
		m_AudioSource = GetComponent<AudioSource>();
		CharacterController controller = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {

		CharacterController controller = GetComponent<CharacterController> ();
		float translation = Input.GetAxis ("Vertical");
		float straffe = Input.GetAxis ("Horizontal");

		Vector3 movedir=head.transform.forward*translation + head.transform.right*straffe;

		if (movedir.y > 0) {
			movedir.y = 0;
		}

		movedir = transform.TransformDirection (movedir);

		movedir *= speed;

		controller.Move (movedir * Time.deltaTime);
		Late(movedir);
	}

	//update after main Update
	void Late(Vector3 movedir)
	{
		if (!m_AudioSource.isPlaying&&(movedir.x!=0||movedir.z!=0)) {

			AudioClip temp;

			int n = Random.Range(1, m_FootstepSounds.Length);

			m_AudioSource.clip = m_FootstepSounds [n];
			m_AudioSource.PlayOneShot (m_AudioSource.clip);
			m_FootstepSounds [n] = m_FootstepSounds [0];
			m_FootstepSounds [0] = m_AudioSource.clip;


		}
	}

}
