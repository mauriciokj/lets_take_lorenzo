using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {
	public float speed;
	public GameObject enemy;
	private PlayerControl player;
	private bool passed;
	private SpawnEnemy spawn;
	public MoveOffset backGround;
	
	// Use this for initialization
	void Start () {
		player = FindObjectOfType (typeof(PlayerControl)) as PlayerControl;
		spawn = FindObjectOfType (typeof(SpawnEnemy)) as SpawnEnemy;
		backGround = FindObjectOfType (typeof(MoveOffset)) as MoveOffset;

	}

	void OnEnable(){
		passed = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (speed, 0, 0) * Time.deltaTime;
		if (player.score >= 30) {
			speed = -16;
			spawn.rateSpawn = 0.3f;
			backGround.speed = 260;
			
		} else if (player.score >= 20) {
			speed = -12;
			spawn.rateSpawn = 0.5f;
			backGround.speed = 198;
		} else if (player.score >= 10) {
			speed = -8;
			backGround.speed = 133;
			spawn.rateSpawn = 0.9f;
			
		}


		if (transform.position.x < player.transform.position.x && !passed){
			passed = true;
			audio.Play ();
			player.addScore();
		}

		if (transform.position.x < -10.5778f){
			enemy.SetActive(false);
		}
		
	}
}
