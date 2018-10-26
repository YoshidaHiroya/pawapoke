using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class nishimura : MonoBehaviour {
	public Sprite oneSprite;
	public Sprite twoSprite;
	public Image image;
	public Image image2;
	SpriteRenderer MainSpriteRenderer;

	// Use this for initialization
	void Start ()
	{
		// このobjectのSpriteRendererを取得
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}

	// 何かしらのタイミングで呼ばれる
	public void ChangeStateToHold()//5番目の顔
	{
		// SpriteRenderのspriteを設定済みの他のspriteに変更
		// 例) HoldSpriteに変更
		image = this.GetComponent<Image>();
		image.sprite = oneSprite;
		//MainSpriteRenderer.sprite = oneSprite;
	}

	public void ChangeStateToHoldSecond()//11番目の顔
	{
		// SpriteRenderのspriteを設定済みの他のspriteに変更
		// 例) HoldSpriteに変更
		image2 = this.GetComponent<Image>();
		image2.sprite = twoSprite;
		MainSpriteRenderer.sprite = twoSprite;
	}
}
