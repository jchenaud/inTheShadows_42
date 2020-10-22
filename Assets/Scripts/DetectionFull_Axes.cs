using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionFull_Axes : MonoBehaviour {

	// Use this for initialization
	// Use this for initialization

	public Vector3 target;
	public Vector3 marge;
	
	// float eulerAngX;
	// float eulerAngY;
	// float eulerAngZ;

	Vector3 actual;

	void victory()
	{
			Debug.Log("WINNNNNN");

	}
	
	// Update is called once per frame
	void Update () {
		// eulerAngX = transform.localEulerAngles.x;
        // eulerAngY = transform.localEulerAngles.y;
        // eulerAngZ = transform.localEulerAngles.z;
		actual = transform.eulerAngles;// (transform.localEulerAngles.x,transform.localEulerAngles.y,transform.localEulerAngles.z)
		print(actual);
		if (target.x < actual.x + marge.x && target.x > actual.x - marge.x) // &&  target.y < actual.y + marge.y && target.y > actual.y - marge.y && target.z < actual.z + marge.z && target.z > actual.z - marge.z)
			print("victory _x");
			// victory();
		if( target.y < actual.y + marge.y && target.y > actual.y - marge.y)
			print("victory _y");

		if(target.z < actual.z + marge.z && target.z > actual.z - marge.z)
			print("victory _z");

	}
}
