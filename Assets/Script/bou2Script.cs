using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bou2Script : MonoBehaviour {
	Rigidbody rb;
	GameObject hpgauge2;
	GameObject Bou1;
	Animator animator;
	Text text;
	GameObject battle;
	GameObject hpgauge;
	BoxCollider bc;
	AudioSource audio;
	AudioSource audiosource;
	public AudioClip punch;
	// Use this for initialization
	void Start () {
		hpgauge2 = GameObject.Find ("gauge2");
		hpgauge = GameObject.Find ("gauge");
		rb = this.gameObject.GetComponent<Rigidbody> ();
		animator = this.gameObject.GetComponent<Animator> ();
		battle = GameObject.Find ("batal");
		text=battle.GetComponent<Text> ();
		audiosource = this.gameObject.GetComponent<AudioSource> ();
		audio = this.gameObject.GetComponent<AudioSource> ();
		bc=this.gameObject.GetComponent<BoxCollider>();
		Bou1 = GameObject.Find ("bou");
	}
	
	// Update is called once per frame
	void Update () {
		//rb.velocity=new Vector3(-10,0,0);
		if (Input.GetKeyDown(KeyCode.D)) {
			transform.Translate (20, 0, 0);
			transform.localScale = new Vector3 (1,1,1);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			transform.Translate (-20, 0, 0);
			transform.localScale = new Vector3 (-1,1,1);

		}

		if (Input.GetKeyDown (KeyCode.S)) {
			animator.SetBool ("attack",true);
			audio.PlayOneShot(punch);
			bc.size = new Vector3(60.0f, 30f, 1.0f);
		}
		if (Input.GetKeyUp (KeyCode.S)) {
			animator.SetBool ("attack",false);
			bc.size = new Vector3(30.0f, 30f, 1.0f);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			animator.SetBool ("kick",true);
			audiosource.Play ();
			bc.size = new Vector3(60.0f, 30f, 1.0f);
		}

		if (Input.GetKeyUp (KeyCode.W)) {
			animator.SetBool ("kick",false);
			bc.size = new Vector3(30.0f, 30f, 1.0f);
		}
		if(hpgauge.GetComponent<Image> ().fillAmount ==0.0f){
			Bou1.GetComponent<bou1Script>().taoreru ();
		}

	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="player1"){
			animator.SetBool ("damage",true);
		}
		//hpgauge.GetComponent<Image> ().fillAmount -= 0.1f;
		//animator.SetBool ("damage",false);
		if(bc.size == new Vector3(30.0f ,30.0f ,1.0f))
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
