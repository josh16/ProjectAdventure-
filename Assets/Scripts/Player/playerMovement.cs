using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float moveSpeed = 5;
	public float turnSpeed = 5;
	public float jumpForce;

	Rigidbody rb;

	public LayerMask groundedLayer;

	public CapsuleCollider col;

	// Use this for initialization
	void Start () {
		
	}
	



	void FixedUpdate()
	{
		
	}

	// Update is called once per frame
	void Update () {

		rb = GetComponent<Rigidbody> ();
		col = GetComponent<CapsuleCollider> ();

		keyBoardControls ();
	}

	//Keyboard Controls
	void keyBoardControls()
	{
		//Movement Controls
		//Left
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-moveSpeed, 0f, 0f);
		}
		//Right
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (moveSpeed, 0f, 0f);
		}
		//Right
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0f, 0f, moveSpeed);
		}
		//Right
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0f, 0f, -moveSpeed);
		}



		//Rotation Controls

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(new Vector3(0,-turnSpeed,0));
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(new Vector3(0,turnSpeed,0));
		}



		//Jump
		if (isGrounded() && Input.GetKeyDown(KeyCode.Space)) {

			rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);


		}

	}


	//Grounded Functions (Checks to see if the player is on the ground)
	private bool isGrounded()
	{
		return Physics.CheckCapsule (col.bounds.center, new Vector3 (col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), 
			col.radius * .10f, groundedLayer);


	}


	//PS4/XB1 Controller
	void ps4Controller()
	{


	}

	



}
