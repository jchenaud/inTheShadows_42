using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.CoreModule;

public class Plyer_pref_man : MonoBehaviour {


	public void reset_play_pref()
	{
	 	PlayerPrefs.SetInt("last_lv_unlock",1);
	 	PlayerPrefs.SetInt("need_play_annim",1);
		PlayerPrefs.SetString("mode","Norm");
		PlayerPrefs.Save();
	}
	// // Use this for initialization
	void Start () {
		if(PlayerPrefs.GetString("mode") == "")
		{
			//print("player_pref is init");
			reset_play_pref();
		}
		
		
	}
	
	// // Update is called once per frame
	// void Update () {
		
	// }
}
