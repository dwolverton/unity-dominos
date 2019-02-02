using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

	public GameObject target;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 v = target.transform.position + offset;
		v.y = 5.46f;
		transform.position = v;
	}
}
