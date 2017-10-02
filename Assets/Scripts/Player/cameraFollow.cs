using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {


	private Camera mainCamera;
	public float cameraDistanceOffset = 10f;
	private GameObject player;


	// Use this for initialization
	void Start () {
		mainCamera = GetComponent<Camera> ();
		player = GameObject.Find ("Player");

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 playerPos = player.transform.position;

		mainCamera.transform.position = new Vector3 (playerPos.x, playerPos.y + 5, playerPos.z - cameraDistanceOffset);
	}
}
