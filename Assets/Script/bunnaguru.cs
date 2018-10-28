using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bunnaguru : MonoBehaviour {
	Text Test;
	AudioSource audiosource;
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
		audiosource = this.GetComponent<AudioSource> ();
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
		//StartCoroutine(SampleCoroutine());

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClickButton(){
		
		sentaku1.GetComponent<Image>().enabled=false;
		sentaku2.GetComponent<Image>().enabled=false;
		sentaku1Text.GetComponent<Text>().enabled=false;
		sentaku2Text.GetComponent<Text>().enabled=false;
		StartCoroutine(SampleCoroutine());

	}
	IEnumerator SampleCoroutine()
	{
		Debug.Log ("あいうえお");

		//Test.text = "ポカッ";
		//audiosource.Play ();
		yield return new WaitUntil(Touch);
		yield return new WaitWhile(Touch);
		Test.text = "カンタ「痛いでヤンス.....。」";
		yield return new WaitUntil(Touch);
		yield return new WaitWhile(Touch);
		Nishimura.GetComponent<nishimura>().ChangeStateToHoldSecond();
		Test.text = "にしむら「いい加減にしたまえ」";
		yield return new WaitUntil(Touch);
		yield return new WaitWhile(Touch);
		Test.text = "カンタ「はーいでヤンス....。」";
		yield return new WaitUntil(Touch);
		yield return new WaitWhile(Touch);
		Test.text ="にしむら「さて、そろそろ町へ戻るか」";
	}
	bool Touch()
	{
		return Input.anyKeyDown;

	}
}
