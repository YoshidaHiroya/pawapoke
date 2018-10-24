using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonText : MonoBehaviour {
	Text Test;
	GameObject Nishimura;
	// Use this for initialization
	void Start()
	{
		Nishimura = GameObject.Find ("nishimura");





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
	}
	bool Touch()
	{
		return Input.anyKeyDown;

	}
}
