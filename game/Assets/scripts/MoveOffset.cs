using UnityEngine;
using System.Collections;

public class MoveOffset : MonoBehaviour {
	private Material currentMaterial;
	private float offSet;
	public float speed;

	// Use this for initialization
	void Start () {
		currentMaterial = renderer.material;
	
	}
	
	// Update is called once per frame
	void Update () {
		offSet += 0.0001f;
		currentMaterial.SetTextureOffset("_MainTex", new Vector2(offSet * speed, 0));
	
	}
}
