using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class nishimura : MonoBehaviour {
	public Sprite oneSprite;
	public Image twoprite;
	public Image threeSprite;
	SpriteRenderer MainSpriteRenderer;

	// Use this for initialization
	void Start ()
	{
		// このobjectのSpriteRendererを取得
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}

	// 何かしらのタイミングで呼ばれる
	public void ChangeStateToHold()
	{
		// SpriteRenderのspriteを設定済みの他のspriteに変更
		// 例) HoldSpriteに変更
		twoprite = this.GetComponent<Image>();
		twoprite.sprite = oneSprite;
		MainSpriteRenderer.sprite = oneSprite;



	}
}
