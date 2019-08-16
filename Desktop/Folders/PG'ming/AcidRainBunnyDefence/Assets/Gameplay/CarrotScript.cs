using UnityEngine;
using System.Collections;

public class CarrotScript : MonoBehaviour {
	Animator CarrotAnimator;
	int TapsTillPopup = 5;
	bool eatable = false;
	bool eaten = false;
	public static bool carrotspawnable = true;
	public static bool OnCarrot = false;
	public static bool carroteffectrabit = false;
	// Use this for initialization
	/*public Sprite four;
	public Sprite three;
	public Sprite two;
	public Sprite one;
	public Sprite zero;
	SpriteRenderer CarrotSprites;*/
	void Start () {
		CarrotAnimator = GetComponent<Animator> ();
		//CarrotSprites = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		//if (TapsTillPopup != 0) {
			//eatable = false;
		//}
		if (eaten == true) {
			Destroy (gameObject);
			carrotspawnable = true;
		}
		if (OnCarrot == true) {
			
			if (eatable == true) {
				eaten = true;
				carroteffectrabit = true;
			}

		}
	}

	void OnMouseDown (){
		if (TapsTillPopup >= 0) {
			TapsTillPopup -= 1;
			//transform.Translate(Vector3.up * 0.03f);
		}
		if (TapsTillPopup == 4) {
			CarrotAnimator.SetBool ("first", true);
			transform.Translate(Vector3.up * 0.02f);
		}
		else if (TapsTillPopup == 3) {
			CarrotAnimator.SetBool ("second", true);
			transform.Translate(Vector3.up * 0.04f);
		}
		else if (TapsTillPopup == 2) {
			CarrotAnimator.SetBool ("third", true);
			transform.Translate(Vector3.up * 0.05f);
		}
		else if (TapsTillPopup == 1) {
			CarrotAnimator.SetBool ("fourth", true);
			transform.Translate(Vector3.up * 0.07f);
		}
		else if (TapsTillPopup == 0) {
			eatable = true;
			CarrotAnimator.SetBool ("fifth", true);
			transform.Translate(Vector3.up * 0.08f);
		}

	}

}
