using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonText : MonoBehaviour {
	Text Test;
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
	void Start()
	{
		Nishimura = GameObject.Find ("nishimura");
		haikei = GameObject.Find ("haikei");
		image = haikei.GetComponent<Image> ();
		sentaku1 = GameObject.Find ("sentaku1");
		sentaku2 = GameObject.Find ("sentaku2");
		sentaku1Text = GameObject.Find ("sentaku1Text");
		sentaku2Text = GameObject.Find ("sentaku2Text");

		sentaku1text = sentaku1Text.GetComponent<Text> ();
		sentaku2text = sentaku2Text.GetComponent<Text> ();
		Test=this.gameObject.GetComponent<Text>();
		StartCoroutine(SampleCoroutine());

	}
	IEnumerator SampleCoroutine()
	{
		Test.text = "にしむら「野球をしよう」\nカンタ「おじさん、臭いでヤンス」";
		yield return new WaitUntil(Touch);
		yield return new WaitWhile(Touch);
		Test.text = "にしむら「臭くないよ、テント生活してるけどちゃんと洗うものは洗っているからね」";
		yield return new WaitUntil(Touch);
		yield return new WaitWhile(Touch);
		Test.text = "カンタ「なるほどでヤンス」" + "\n" + "カンタ「臭いでヤンス」";
		yield return new WaitUntil(Touch);
		yield return new WaitWhile(Touch);
		Nishimura.GetComponent<nishimura>().ChangeStateToHold();
		Test.text = "にしむら「だから臭くないって！」";
		yield return new WaitUntil(Touch);
		yield return new WaitWhile(Touch);
		Test.text = "カンタ「臭いでヤンス〜〜〜〜〜！！！！」";
		sentaku1.GetComponent<Image>().enabled=true;
		sentaku2.GetComponent<Image>().enabled=true;
		sentaku1Text.GetComponent<Text>().enabled=true;
		sentaku2Text.GetComponent<Text>().enabled=true;
		sentaku1text.text = "本当のことを言う";
		sentaku2text.text="ぶん殴る";
		//image.sprite = haikei2;

	}
	bool Touch()
	{
		return Input.anyKeyDown;

	}
}
