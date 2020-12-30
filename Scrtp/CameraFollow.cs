using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject carTransform;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		carTransform = GameObject.FindGameObjectWithTag ("Player");
		offset = transform.position - carTransform.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = carTransform.transform.position + offset;
	}
}
