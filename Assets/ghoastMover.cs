using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghoastMover : MonoBehaviour {

	Rigidbody myrig;

	float mass;
	public float speed;

	public Transform flipMe;

	private void Awake()
	{
		myrig = GetComponent<Rigidbody>();
		mass = myrig.mass;
		}

	// Update is called once per frame
	void Update () {
		myrig.AddForce(new Vector3(Input.GetAxis("Horizontal")*mass * speed, Input.GetAxis("Vertical")*mass * speed));
		if (Input.GetAxis("Horizontal") > 0) { flipMe.localScale = new Vector3(-1f,1,1); }
		else if (Input.GetAxis("Horizontal") < 0) { flipMe.localScale = new Vector3(1f, 1, 1); }
	}
}
