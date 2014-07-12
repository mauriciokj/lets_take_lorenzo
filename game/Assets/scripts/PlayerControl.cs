using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float speedX;
	public float speedY;
	public GameObject player;
	public float maxHeight;
	public float minHeight;
	public float maxWidth;
	public float minWidth;
	public int score;
	public TextMesh textScore;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		PlayerPrefs.SetInt("score", score);
		if (score > PlayerPrefs.GetInt ("record")) {
			PlayerPrefs.SetInt("record", score);
		}
		Application.LoadLevel("gameOver");
		}
	
	// Update is called once per frame
	void Update () {
		float translationY = Input.GetAxis("Vertical") * speedY;
		float translationX = Input.GetAxis("Horizontal") * speedX;

		player.transform.Translate (translationX,translationY,0);
		textScore.text = score.ToString ();

		if (player.transform.position.y > maxHeight) {
			player.transform.position = new Vector3(player.transform.position.x, maxHeight,0);
		}
		else if (player.transform.position.y < minHeight) {
			player.transform.position = new Vector3(player.transform.position.x,minHeight,0);
		}
		else if (player.transform.position.x > maxWidth) {
			player.transform.position = new Vector3(maxWidth, player.transform.position.y,0);
		}
		else if (player.transform.position.x < minWidth) {
			player.transform.position = new Vector3(minWidth, player.transform.position.y,0);
		}
	}
	public void addScore(){
		score ++;
	}
}
