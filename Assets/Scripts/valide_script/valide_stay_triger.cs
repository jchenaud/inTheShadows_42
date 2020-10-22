using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valide_stay_triger : MonoBehaviour {

	public bool reverse_zone;

	public bool valide =  false;

	

	public GameObject target;

	void OnTriggerStay(Collider other)
	{
        //print(other.transform.gameObject.name);
        try
        {
            if (other.transform.gameObject.name == target.transform.name)
            {
                if (reverse_zone == false)
                    valide = true;
                else
                    valide = false;
            }
        }
        catch
        {
            Debug.LogError("bug 1");
        }
	}

	void OntriggerEnter(Collider other)
	{
        try
        {
            //print(other.transform.gameObject.name);
            if (other.transform.gameObject == target.gameObject)
            {
                if (reverse_zone == false)
                    valide = true;
                else
                    valide = false;
            }
        }
        catch
        {
            Debug.LogError("bug 1");
        }
    }

    void OnTriggerExit(Collider other)
	{
        try
        {
            //print( "exit " +  other.transform.gameObject.name);
            if (other.transform.gameObject == target.gameObject)
            {
                if (reverse_zone == false)
                    valide = false;
                else
                    valide = true;
            }
        }
        catch
        {
            Debug.LogError("bug 3");
        }
	}
	// // Use this for initialization
	// void Start () {
		
	// }
	
	 // Update is called once per frame
	 void Update () {
        Debug.Log(valide);
	 }
}
