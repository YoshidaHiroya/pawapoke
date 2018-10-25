using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bunnaguru : MonoBehaviour {
	Text Test;
	GameObject Text;
	GameObject Nishimura;
	GameObject haikei;
	GameObject sentaku1;
	GameObject sentaku2;
	GameObject sentaku1Text;
	GameObject sentaku2Text;
	Text sentaku1text;
	Text sentaku2text;
	Image image;
	public Sprite haikei2;
	// Use this for initialization
	void Start () {
		Nishimura = GameObject.Find ("nishimura");
		haikei = GameObject.Find ("haikei");
		image = haikei.GetComponent<Image> ();
		sentaku1 = GameObject.Find ("sentaku1");
		sentaku2 = GameObject.Find ("sentaku2");
		sentaku1Text = GameObject.Find ("sentaku1Text");
		sentaku2Text = GameObject.Find ("sentaku2Text");
		Text = GameObject.Find ("Text");
		sentaku1text = sentaku1Text.GetComponent<Text> ();
		sentaku2text = sentaku2Text.GetComponent<Text> ();
		Test=Text.GetComponent<Text>();
	//	StartCoroutine(SampleCoroutine());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClickButton(){
		Test.text = "あいうえお";
	}
	//IEnumerator SampleCoroutine()
	//{
		
	//}
	bool Touch()
	{
		return Input.anyKeyDown;

	}
}
