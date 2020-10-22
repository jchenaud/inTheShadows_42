﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_test : MonoBehaviour {

	// Use this for initialization

	public GameObject[] valide_o;

	public bool check_only_same_layer;

	 //public GameObject valide2;

	 //premier cheker forward after up 

	public bool valide;
	void Start () {
		
	}
	
	// Update is called once per frame
	bool check_ray_hit_valid(Vector3 vec, GameObject hit_obj)
	{
		RaycastHit hit;
		if (Physics.Raycast(transform.position, vec, out hit,50)) // if (Physics.Raycast(transform.position, vec, out hit,50,gameObject.layer))
		{
			Debug.DrawRay(transform.position,vec *50, Color.blue);
			if(hit.transform.gameObject == hit_obj)
				return true;
			else
			{
				Debug.DrawRay(transform.position,vec *50, Color.red);
				return false;
			}
		}
		else
		{
			Debug.DrawLine(transform.position,transform.position + (transform.TransformDirection(Vector3.forward)*500));
			return false;
		}

	}


	bool check_ray_hit_valid_mask(Vector3 vec, GameObject hit_obj)
	{
		RaycastHit hit;
		//print("call");
		if (Physics.Raycast(transform.position, vec, out hit,50,~gameObject.layer)) // if (Physics.Raycast(transform.position, vec, out hit,50,gameObject.layer))
		{
			Debug.DrawRay(transform.position,vec *50, Color.blue);
			if(hit.transform.gameObject == hit_obj)
				return true;
			else
				return false;
		}
		else
		{
			Debug.DrawLine(transform.position,transform.position + (transform.TransformDirection(Vector3.forward)*500));
			return false;
		}
	}

int i = 0;
Vector3 vec;
	void Update () {
		  //RaycastHit hit1;
        // Does the ray intersect any objects excluding the player layer
        // if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit1,50))
		// {
		// 	Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) *50, Color.blue);
		// 	if(hit1.transform.gameObject ==  valide1)
		// 		print("valide1");
		// 	else
		// 		return;
		// }
		// else
		// {
		// 	Debug.DrawLine(transform.position,transform.position + (transform.TransformDirection(Vector3.forward)*500));
		// 	return;
		// }
		
		i = 0;
		foreach(GameObject obj in valide_o)
		{
			switch (i)
      		{
          	case 0:
            	  vec = transform.TransformDirection(Vector3.forward);
              	break;
          	case 1:
            	  vec = transform.TransformDirection(Vector3.up);
              	break;
          	case 2:
			//   print("plopp");
            	  vec =  transform.TransformDirection(Vector3.left);
              break;
     		}
			
			switch (check_only_same_layer)
      		{
          	case false:
            	if(check_ray_hit_valid(vec,obj) == false)
				{
					valide =  false;
					return;
				}
              	break;
          	case true:
            	if(check_ray_hit_valid_mask(vec,obj) == false)
				{
					valide =  false;
					return;
				}
              	break;
			}
			// if(check_ray_hit_valid(vec,obj) == false)
			// {
			// 	valide =  false;
			// 	return;
			// }
			i++;
		}


		// RaycastHit hit2;
        // // Does the ray intersect any objects excluding the player layer
        // if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit2,50))
		// {
		// 	Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) *50, Color.blue);
		// 	if(hit2.transform.gameObject ==  valide2)
		// 		print("valide2");
		// 	else
		// 		return;

		// }
		// else
		// {
		// 	Debug.DrawLine(transform.position,transform.position + (transform.TransformDirection(Vector3.up)*500));
		// 	return;
			
		// }
		valide = true;
		//print("Win");
	}
}
