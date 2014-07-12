using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public TextMesh record;
	public TextMesh score;

	// Use this for initialization
	void Start () {
		record.text = PlayerPrefs.GetInt ("record").ToString ();
		score.text = PlayerPrefs.GetInt ("score").ToString (); 
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Application.LoadLevel("game");
		}
	
	}
}
