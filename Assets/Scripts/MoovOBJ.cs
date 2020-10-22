using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoovOBJ : MonoBehaviour {

		
	
	// Update is called once per frame
//	Vector3 rot;

	//Vector3 tmp_mouseP;
	Vector3 screenPos;

	 public float speed;

	 public Vector3 poitR;

	 public bool object_select =  true;
// Use this for initialization
void Start () {
	// poitR = transform.position();
}
	void Update () {
		
		if (object_select == false)
			return;
		float modifier;
		if(Input.GetMouseButton(0))
		{
			//print("click");
			screenPos = Camera.main.WorldToScreenPoint(transform.position);
			if (Input.mousePosition.x >= screenPos.x)
				modifier = speed;
			else
				modifier = -speed;
			transform.RotateAround(transform.position,Vector3.up,modifier * Time.deltaTime); // la bone pour un axe mis bizzarement sa merde si plutieur 
		}
		else if(Input.GetMouseButton(1))
		{
		//	print("click _ 1");
			screenPos = Camera.main.WorldToScreenPoint(transform.position);
			if (Input.mousePosition.y >= screenPos.y)
				modifier = speed;
			else
				modifier = -speed;
			transform.RotateAround(transform.position,Vector3.right,modifier * Time.deltaTime);

		}

	}
}
