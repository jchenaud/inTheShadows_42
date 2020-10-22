using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Get_set_info : MonoBehaviour {

	// Use this for initialization


	public GameObject[] lv_pos;

	public Text arrive_txt;

	public int pos_to_go;
	
	void Awake () { //Awake
		if(PlayerPrefs.GetString("mode") == "DEV")
		{
            // SceneManager.LoadScene("world_map");
            if (pos_to_go == 0)
                pos_to_go = 1;
            transform.GetComponent<mov_to>().pos_end = lv_pos[pos_to_go];
            arrive_txt.text = "Welcome to " + lv_pos[pos_to_go].name;

            return;
		}
		pos_to_go =  PlayerPrefs.GetInt("last_lv_unlock");
		if(PlayerPrefs.GetString("mode") == "Norm")//PlayerPrefs.GetInt("need_play_annim") == 1
        {
			try{
			//print("pos to go  =" + pos_to_go.ToString());
			transform.GetComponent<mov_to>().pos_b =  lv_pos[pos_to_go - 1];
			transform.GetComponent<mov_to>().pos_end =  lv_pos[pos_to_go];
			arrive_txt.text =  "Welcome to " + lv_pos[pos_to_go].name;
			}
			catch{
				Debug.LogWarning(" Argument out of range : " + pos_to_go.ToString());
				if(pos_to_go ==  7)
					arrive_txt.text = "OH !! you finish this game as a pro !!\n Thank you for your time !";

			}
		}
	}

	public void play_lv()
	{
		SceneManager.LoadScene("lv_" + pos_to_go);
	}

	public void go_main_menue()
	{
		SceneManager.LoadScene("Main_menue");
	}

	
	public void reaload(int new_dest)
	{
		pos_to_go =  new_dest;
		arrive_txt.text =  "Welcome to " + lv_pos[pos_to_go].name;

	}
	
	// // Update is called once per frame
	// void Update () {
		
	// }
}
