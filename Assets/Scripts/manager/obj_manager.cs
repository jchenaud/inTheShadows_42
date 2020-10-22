using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_manager : MonoBehaviour {

	// Use this for initialization

	public GameObject[] obj; //obj avec <MoovOBJ>
	public bool move_obj;

	public int actual = 0;

	public float ofcet_moove;
	void Start () {
		foreach(GameObject o in obj)
		{
			o.GetComponentInChildren<MoovOBJ>().object_select = false;
		}
		obj[actual].GetComponentInChildren<MoovOBJ>().object_select = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(2))
		{
			obj[actual].GetComponentInChildren<Renderer>().material.color =  Color.grey;
			obj[actual].GetComponentInChildren<MoovOBJ>().object_select = false;
			if (actual < obj.Length - 1)
			 	actual ++;
			else
				actual =  0;
			obj[actual].GetComponentInChildren<MoovOBJ>().object_select = true;
			obj[actual].GetComponentInChildren<Renderer>().material.color =  Color.white;
		}
		if(move_obj == false)
			return;
		if((Input.GetKey("left ctrl") || Input.GetKey("space") )) // && Input.GetMouseButtonDown(1))
		{
			obj[actual].GetComponentInChildren<MoovOBJ>().enabled = false;
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
			//Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition)
       		if (Physics.Raycast(ray, out hit, Mathf.Infinity,LayerMask.GetMask("projection"))) //
        		{
            		// Debug.DrawRay(transform.position, hit.transform.position , Color.yellow);
           		//	Debug.Log(hit.transform.name);
				//	print(hit.transform.position);
					obj[actual].transform.position = ray.GetPoint(ofcet_moove); //hit.transform.position; //+ ofcet_moove;
        		}
        	// else
        	// 	{
          	// 	  	// Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
           	// 		Debug.Log("Did not Hit");
        	// 	}
			obj[actual].GetComponentInChildren<MoovOBJ>().enabled = true;
			
		}
		// 	obj[actual].GetComponent<MoovOBJ>().enabled = false;
		// 	// obj[actual].transform.parent.position =  Input.mousePosition;
		//  Vector3 clickedPosition =  Input.mousePosition; //Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//  print(clickedPosition);
		//  obj[actual].transform.position.x = clickedPosition.x
		// //  print(clickedPosition);
		// //  print(Input.mousePosition);
        // //  obj[actual].transform.parent.position = Vector3.Lerp(obj[actual].transform.parent.position, clickedPosition,Time.deltaTime);
	}
}
