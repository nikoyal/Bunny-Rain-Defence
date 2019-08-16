using UnityEngine;
using System.Collections;

public class MuteButton : MonoBehaviour {
	SpriteRenderer sr;
	public Sprite Muted;
	public Sprite On;
	bool mute = false;
	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (mute == false) {
			sr.sprite = On;
			AudioListener.volume = 1;
		}
		else if (mute == true) {
			sr.sprite = Muted;
			AudioListener.volume = 0;
		}
	}
	void OnMouseDown (){
		if (mute == false) {
			mute = true;
		} else
			mute = false;
	}
}
