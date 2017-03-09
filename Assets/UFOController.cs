using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	//private Transform myTransform;
	private Rigidbody2D myRigidBody2D;
	public float forceValue;
	public ScoreManager scoreManager;

	// Use this for initialization
	void Start () {
		//myTransform = this.GetComponent<Transform> ();
		myRigidBody2D = this.GetComponent<Rigidbody2D>();
	}

	public float speed;

	// Update is called once per frame
	void Update () {
		Vector2 force2D = Vector2.zero;

		if (Input.GetKey (KeyCode.W)) {
			//myTransform.position += new Vector3(0, speed * Time.deltaTime, 0);
			//myRigidBody2D.AddForce(new Vector2());
			force2D.y += forceValue;
		}
		if (Input.GetKey (KeyCode.S)) {
			//myTransform.position += new Vector3(0, -speed * Time.deltaTime, 0);
			force2D.y -= forceValue;
		}
		if (Input.GetKey (KeyCode.A)) {
			//myTransform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
			force2D.x -= forceValue;
		}
		if (Input.GetKey (KeyCode.D)) {
			//myTransform.position += new Vector3(speed * Time.deltaTime, 0, 0);
			force2D.x += forceValue;
		}
		myRigidBody2D.AddForce (force2D);

	}

	private void OnTriggerEnter2D(Collider2D other){
		scoreManager.AddScore (100);
		other.gameObject.SetActive (false);
	}
}
