using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MiniMenuTxt : MonoBehaviour {
	public Text Score;
	public Text PersonalBest;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PersonalBest.text = ("Best : " + Stats.personalbest);
		Score.text = ("Score : " + Stats.score);
	}
		
}
