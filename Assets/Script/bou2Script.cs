using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bou2Script : MonoBehaviour {
	Rigidbody rb;
	Animator animator;

	// Use this for initialization
	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody> ();
		animator = this.gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity=new Vector3(-10,0,0);
	}

	public void taoreru(){
		//Debug.Log ("たおれる");
		animator.SetBool ("taoreru",true);
	}

}
