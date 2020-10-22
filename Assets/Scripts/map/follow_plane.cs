using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_plane : MonoBehaviour {

	// Use this for initialization

	public GameObject plane;
	private Vector3 pos;
	void Start () {
		plane = GameObject.Find("plane");
	}
	
	// Update is called once per frame
	void Update () {
		pos =  plane.transform.position;
		pos.y = this.transform.position.y;
		this.gameObject.transform.position = pos;
	}
}
