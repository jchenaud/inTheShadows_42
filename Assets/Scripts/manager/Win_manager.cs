using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Win_manager : MonoBehaviour {

	public GameObject [] validation_obj_ray;
    public GameObject [] validation_obj_box;

    public GameObject victory_menue;
    bool victory = false;
    void Update()
    {
        foreach (GameObject obj in validation_obj_ray)
        {
            if (obj.GetComponent<Raycast_test>().valide == false)
                return;
        }
        foreach (GameObject obj in validation_obj_box)
        {
            if (obj.GetComponent<valide_stay_triger>().valide == false)
                return;
        }
        if (victory == false)
        {
            victory_menue.SetActive(true);
            victory =  true;
            Debug.Log("level is Finich");
        }
    }


    //public int Lv;

    //bool victory =  false;

    //// Use this for initialization
    //// void Start () {

    //// }

    //// Update is called once per frame
    //void Update () {
    //       Debug.Log("coucou");

    //       try
    //       {
    //           Debug.Log("coucou 1.5");

    //           foreach (GameObject obj in validation_obj)
    //           {
    //               Debug.Log("coucou f");

    //               try
    //               {
    //                   Debug.Log("coucou 2"); // ici

    //                   if (obj.GetComponent<Raycast_test>().valide == false)
    //                       return;
    //                   Debug.Log("coucou 2.5"); 

    //               }
    //               catch
    //               {
    //                   Debug.Log("coucou 3");

    //                   try
    //                   {
    //                       if (obj.GetComponent<valide_stay_triger>().valide == false)
    //                           return;
    //                   }
    //                   catch
    //                   {
    //                       print("no valide script on this obj");
    //                   }
    //                   Debug.Log("out");
    //               }
    //           }
    //       }
    //       catch
    //       {
    //           Debug.LogError("Foreach bug");
    //       }
    //	if(victory  ==  false)
    //	{
    //           Debug.Log("level is supse to finish in sec ");

    //           try
    //           {
    //		victory_menue.SetActive(true);
    //		}
    //		catch
    //		{
    //			Debug.Log("WTF");
    //		}
    //		// if(Lv > PlayerPrefs.GetInt("last_lv_unlock") ||  Lv + 1 > PlayerPrefs.GetInt("last_lv_unlock"))
    //		// {
    //		// 	if(0 != PlayerPrefs.GetInt("last_lv_unlock"))
    //		// 		PlayerPrefs.SetInt("last_lv_unlock", Lv + 1);
    //		// 	else
    //		// 		PlayerPrefs.SetInt("last_lv_unlock", Lv);

    //		// }
    //		victory =  true;
    //           Debug.Log("level is Finich");
    //	}


    //}
}
