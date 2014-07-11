using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnEnemy : MonoBehaviour {
	public float maxHeight;
	public float minHeight;
	public float rateSpawn;
	public GameObject prefab;
	public List<GameObject> enemies; 
	public int maxEnemies;
	private float currentRateSpawn;
	
	
	
	// Use this for initialization
	void Start () {
		for(int i=0; i < maxEnemies; i++){
			GameObject tempEnemy = Instantiate(prefab) as GameObject;
			enemies.Add(tempEnemy);
			tempEnemy.SetActive(false);
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		currentRateSpawn += Time.deltaTime;
		if (currentRateSpawn > rateSpawn){
			currentRateSpawn = 0;
			Spawn();
		}
	}
	
	private void Spawn(){
		int rand = Random.Range (0, 9);

		GameObject tempEnemy = null;
		for(int i=0; i < maxEnemies; i++){
			if (enemies[i].activeSelf == false){
				tempEnemy = enemies[i];
				break;
			}
		}
		if (tempEnemy != null) {
			tempEnemy.transform.position = new Vector3(transform.position.x, (rand < 4 ? minHeight : maxHeight), transform.position.z);
			tempEnemy.SetActive(true);
		}
	}
}
