using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bou1Script : MonoBehaviour {
	GameObject hpgauge2;
	Animator animator;
	AudioSource audiosource;
	AudioSource audio;
	public AudioClip punch;
	// Use this for initialization
	void Start () {
		hpgauge2 = GameObject.Find ("gauge2");
		animator = this.gameObject.GetComponent<Animator> ();
		audiosource = this.gameObject.GetComponent<AudioSource> ();
		audio = this.gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("right")) {
			transform.Translate (20, 0, 0);
		}
		if (Input.GetKeyDown ("left")) {
			transform.Translate (-20, 0, 0);
		}
		if (Input.GetKeyDown ("space")) {
			animator.SetBool ("atack",true);
			audio.PlayOneShot(punch);
		}
		if (Input.GetKeyUp ("space")) {
			animator.SetBool ("atack",false);
		}
		if (Input.GetKeyDown ("up")) {
			animator.SetBool ("kick",true);
			audiosource.Play ();
		}

		if (Input.GetKeyUp ("up")) {
			animator.SetBool ("kick",false);
		}

		if (Input.GetKeyDown ("down")) {
			animator.SetBool ("tameru",true);
		}

		if (Input.GetKeyUp ("down")) {
			animator.SetBool ("tameru",false);
		}




	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="player2"){
			animator.SetBool ("damage",true);
		}
		hpgauge2.GetComponent<Image> ().fillAmount -= 0.1f;
		animator.SetBool ("damage",false);
	}

}
