using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_mouse2d : MonoBehaviour {

	
	
	// Update is called once per frame
	//Vector3 rot;

//	Vector3 tmp_mouseP;
	Vector3 screenPos;

	 public float speed;

	 public Vector3 poitR;
// Use this for initialization
void Start () {
	// poitR = transform.position();
}
	void Update () {
		
		float modifier;
		if(Input.GetMouseButton(0))
		{
			print("click");
			// rot = transform.eulerAngles;
			screenPos = Camera.main.WorldToScreenPoint(transform.position);
			if (Input.mousePosition.x >= screenPos.x)
				modifier = speed;
			else
				modifier = -speed;
			// rot  = new Vector3(rot.x,rot.y+(modifier*Time.deltaTime),rot.z);
			// rot  = new Vector3(rot.x,rot.y,rot.z+(modifier*Time.deltaTime));

			
			// transform.rotation =   Quaternion.Euler(rot);

			// print((modifier * Time.deltaTime /100));
			// transform.Rotate(actual.x,actual.y + (modifier * Time.deltaTime /100),actual.z);
		transform.RotateAround(transform.position,Vector3.up,modifier * Time.deltaTime); // la bone pour un axe mis bizzarement sa merde si plutieur 
		// transform.RotateAround(transform.position,transform.TransformDirection(Vector3.forward),modifier * Time.deltaTime); 
		}
		// else if(Input.GetMouseButton(1))
		// {
		// 	print("click _ 1");
		// 	// rot = transform.eulerAngles;
		// 	screenPos = Camera.main.WorldToScreenPoint(transform.position);
		// 	if (Input.mousePosition.y >= screenPos.y)
		// 		modifier = speed;
		// 	else
		// 		modifier = -speed;
		
		// 	//   rot  = new Vector3(rot.x+(modifier*Time.deltaTime),rot.y,rot.z);
			
		// 	// transform.rotation =   Quaternion.Euler(rot);
			
		// 	// print(transform.position.ToString()  + Vector3.right.ToString() + modifier);
		// 	// rot = transform.eulerAngles;
		// 	transform.RotateAround(transform.position,transform.TransformDirection(Vector3.right),modifier * Time.deltaTime);
		// 	// rot  = new Vector3(transform.rotation.x,rot.y,rot.z);
		// 	// print(transform.localEulerAngles.ToString() +  transform.eulerAngles);
			
		// }
		// // tmp_mouseP = Input.mousePosition;
	}
}
