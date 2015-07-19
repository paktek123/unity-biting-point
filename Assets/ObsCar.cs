using UnityEngine;
using System.Collections;

public class ObsCar : MonoBehaviour {

	// Movement speed
	public float speed = 2;
	
	// Flap force
	//public float force = 300;
	
	// Use this for initialization
	void Start () {    
		// Fly towards the right
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
