using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bou1Script : MonoBehaviour {
	GameObject hpgauge2;
	Animator animator;
	// Use this for initialization
	void Start () {
		hpgauge2 = GameObject.Find ("gauge2");
		animator = this.gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("right")) {
			transform.Translate (10, 0, 0);
		}
		if (Input.GetKeyDown ("left")) {
			transform.Translate (-10, 0, 0);
		}
		if (Input.GetKeyDown ("space")) {
			animator.SetBool ("atack",true);
		}
		if (Input.GetKeyUp ("space")) {
			animator.SetBool ("atack",false);
		}
	}
	void OnCollisionEnter(Collision collision){
		Debug.Log("あたったよ");
		hpgauge2.GetComponent<Image> ().fillAmount -= 0.1f;
	}

}
