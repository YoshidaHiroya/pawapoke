using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bou2Script : MonoBehaviour {
	Rigidbody rb;
	Animator animator;
	Text text;
	GameObject battle;
	// Use this for initialization
	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody> ();
		animator = this.gameObject.GetComponent<Animator> ();
		battle = GameObject.Find ("batal");
		text=battle.GetComponent<Text> ();
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
	}

	public void taoreru(){
		//Debug.Log ("たおれる");
		text.text="バトルシュウリョウ！";
		animator.SetBool ("taoreru",true);
	}

}
