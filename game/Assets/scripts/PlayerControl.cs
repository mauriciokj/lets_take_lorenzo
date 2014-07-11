using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float speed;
	public GameObject player;
	public float maxHeight;
	public float minHeight;
	public int score;
	public TextMesh textScore;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		Application.LoadLevel("gameOver");
		}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis("Vertical") * speed;

		player.transform.Translate (0,translation,0);
		textScore.text = score.ToString ();

		if (player.transform.position.y > maxHeight) {
			player.transform.position = new Vector3(player.transform.position.x, maxHeight,0);
		}
		else if (player.transform.position.y < minHeight) {
			player.transform.position = new Vector3(player.transform.position.x,minHeight,0);
		}
	}
	public void addScore(){
		score ++;
	}
}
