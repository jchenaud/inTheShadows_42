using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Victory_m : MonoBehaviour {

	public  int actual_lv;



	public void continue_b()// bouton cotinue du menue de victoire
	{
		if(PlayerPrefs.GetString("mode") == "DEV")
		{

			SceneManager.LoadScene("world_map");
			return;
		}

		if(PlayerPrefs.GetInt("last_lv_unlock") == actual_lv)
		{
            PlayerPrefs.SetInt("need_play_annim", 1);

            PlayerPrefs.SetInt("last_lv_unlock",actual_lv +1);
			PlayerPrefs.Save();
			SceneManager.LoadScene("world_map");
		}
		else
			SceneManager.LoadScene("world_map");

	}

	public void  quit()// bouton quit du menue de victoire
	{
		if(PlayerPrefs.GetString("mode") == "DEV")
		{
			SceneManager.LoadScene("main_menue");
			PlayerPrefs.Save();
			return;
		}
        if (PlayerPrefs.GetInt("last_lv_unlock") == actual_lv)
        {
            PlayerPrefs.SetInt("last_lv_unlock", actual_lv + 1);
            PlayerPrefs.SetInt("need_play_annim", 1);
        }
        PlayerPrefs.Save();
			SceneManager.LoadScene("main_menue");
	}

	// Use this for initialization
	// void Start () {
		
	// }
	
	// // Update is called once per frame
	// void Update () {
		
	// }

	
}
