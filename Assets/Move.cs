using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public Rigidbody physics;
	public float force = 1.0f;

	void Start () {

		physics.AddForce (transform.right * force, ForceMode.Impulse);
	}
}
