using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_m : MonoBehaviour {

	// Use this for initialization

	public GameObject main;
	public GameObject optn;

	void Start () {
		optn.SetActive(false);
		main.SetActive(true);
		
	}

	public void activate_optn()
	{
		if(optn.activeInHierarchy)
			optn.SetActive(false);
		else
			optn.SetActive(true);


	}
	public void play()
	{
		PlayerPrefs.SetString("mode","Norm");

		SceneManager.LoadScene("world_map");

	}

	public void play_as_master()
	{
		PlayerPrefs.SetString("mode","DEV");

		SceneManager.LoadScene("world_map");
	}

public void appQuit()
	{
		PlayerPrefs.Save();
		print("quit");
		Application.Quit();
	}

	// // Update is called once per frame
	// void Update () {
		
	// }
}
