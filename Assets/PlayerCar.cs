using UnityEngine;
using System.Collections;

public class PlayerCar : MonoBehaviour {
	// Movement speed
	public float speed = 2;
	
	// Flap force
	public float force = 300;
	
	// Use this for initialization
	void Start () {    
		// Fly towards the right
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
		// Move left / right
		if (Input.GetKeyDown(KeyCode.LeftArrow))
			GetComponent<Rigidbody2D>().AddForce(Vector2.left * force);

		if (Input.GetKeyDown(KeyCode.RightArrow))
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * force);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		// Restart
		Application.LoadLevel(Application.loadedLevel);
	}
}
