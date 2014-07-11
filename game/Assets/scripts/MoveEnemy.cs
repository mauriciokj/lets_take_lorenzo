using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {
	public float speed;
	public GameObject enemy;
	private PlayerControl player;
	private bool passed;
	
	// Use this for initialization
	void Start () {
		player = FindObjectOfType (typeof(PlayerControl)) as PlayerControl;
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (speed, 0, 0) * Time.deltaTime;

		if (transform.position.x < player.transform.position.x && !passed){
			passed = true;
			player.addScore();
		}

		if (transform.position.x < -10.5778f){
			enemy.SetActive(false);
		}
		
	}
}
