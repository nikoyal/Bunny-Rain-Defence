using UnityEngine;
using System.Collections;

public class eightbitmusic : MonoBehaviour {

	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
		Application.LoadLevel ("MainMainMenu");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
