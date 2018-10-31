using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bou1Script : MonoBehaviour {
	GameObject hpgauge2;
	GameObject hpgauge;
	GameObject Bou2;
	Animator animator;
	GameObject battle;
	AudioSource audiosource;
	AudioSource audio;
	Rigidbody rb;
	BoxCollider bc;
	Text text;
	public AudioClip punch;
	// Use this for initialization
	void Start () {
		hpgauge2 = GameObject.Find ("gauge2");
		hpgauge = GameObject.Find ("gauge");
		battle = GameObject.Find ("batal");
		animator = this.gameObject.GetComponent<Animator> ();
		audiosource = this.gameObject.GetComponent<AudioSource> ();
		audio = this.gameObject.GetComponent<AudioSource> ();
		rb = this.gameObject.GetComponent<Rigidbody> ();
		bc=this.gameObject.GetComponent<BoxCollider>();
		text=battle.GetComponent<Text> ();
		Bou2 = GameObject.Find ("bou2");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("right")) {
			transform.Translate (40, 0, 0);
			transform.localScale = new Vector3 (1,1,1);
		}
		if (Input.GetKeyDown ("left")) {
			transform.Translate (-40, 0, 0);
			transform.localScale = new Vector3 (-1,1,1);
		}
		if (Input.GetKeyDown ("space")) {
			animator.SetBool ("atack",true);
			audio.PlayOneShot(punch);
			bc.size = new Vector3(60.0f, 30f, 1.0f);
		}
		if (Input.GetKeyUp ("space")) {
			animator.SetBool ("atack",false);
			bc.size = new Vector3(30.0f, 30f, 1.0f);
		}
		if (Input.GetKeyDown ("up")) {
			animator.SetBool ("kick",true);
			audiosource.Play ();
			bc.size = new Vector3(60.0f, 30f, 1.0f);
		}

		if (Input.GetKeyUp ("up")) {
			animator.SetBool ("kick",false);
			bc.size = new Vector3(30.0f, 30f, 1.0f);
		}

		if (Input.GetKeyDown ("down")) {
			animator.SetBool ("tameru",true);
		}

		if (Input.GetKeyUp ("down")) {
			animator.SetBool ("tameru",false);
		}
		if(hpgauge2.GetComponent<Image> ().fillAmount ==0.0f){
			Bou2.GetComponent<bou2Script>().taoreru ();
		}



	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="player2"){
			animator.SetBool ("damage",true);
		}
		//hpgauge2.GetComponent<Image> ().fillAmount -= 0.1f;
		//animator.SetBool ("damage",false);
		if(bc.size == new Vector3(60.0f ,30.0f ,1.0f))
		{
			hpgauge2.GetComponent<Image> ().fillAmount -= 0.1f;
		}

	}
	public void taoreru(){
		//Debug.Log ("たおれる");
		text.text="バトルシュウリョウ！";
		animator.SetBool ("taoreru",true);
	}

}
