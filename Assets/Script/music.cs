using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {
	AudioSource audiosource;
	// Use this for initialization
	void Start () {
		audiosource = this.gameObject.GetComponent<AudioSource> ();
		audiosource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
