using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public Transform target;
	public float distance = 10.0f;
	public float height = 5.0f;
	public float smooth = 1.0f;
	Vector3 velocity = Vector3.zero;

	void LateUpdate () {

		Vector3 targetPosition = target.position - Vector3.forward * distance + Vector3.up * height;
		transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smooth);
		transform.LookAt (target);
	}
}
