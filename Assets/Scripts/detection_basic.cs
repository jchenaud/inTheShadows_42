using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection_basic : MonoBehaviour {

	// Use this for initialization

	public Vector3 target;
	
	// float eulerAngX;
	// float eulerAngY;
	// float eulerAngZ;

	Vector3 actual;

	
	// Update is called once per frame
	void Update () {
		// eulerAngX = transform.localEulerAngles.x;
        // eulerAngY = transform.localEulerAngles.y;
        // eulerAngZ = transform.localEulerAngles.z;
		actual = transform.eulerAngles;// (transform.localEulerAngles.x,transform.localEulerAngles.y,transform.localEulerAngles.z)

		if (target.y < actual.y + 2 && target.y > actual.y - 2)
			Debug.Log("WINNNNNN");

	}
}
