using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghoastMover : MonoBehaviour {

	Rigidbody myrig;

	float mass;
	public float speed;

	private void Awake()
	{
		myrig = GetComponent<Rigidbody>();
		mass = myrig.mass;
		}

	// Update is called once per frame
	void Update () {
		myrig.AddForce(new Vector3(Input.GetAxis("Horizontal")*mass * speed, Input.GetAxis("Vertical")*mass * speed));
	}
}
