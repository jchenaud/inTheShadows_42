using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Passport_Mnager : MonoBehaviour {

	// Use this for initialization

	public Sprite approuved;
	public Sprite pending;
	public Sprite Waiting_list;


	public List<GameObject>  child =  new List<GameObject>();
	void Start () {
		int size =  gameObject.transform.childCount;
		for (int i = 0; i < size; i++)
		{
			child.Add(gameObject.transform.GetChild(i).gameObject);
		}
	}
	public int actual_lv;
	// Update is called once per frame
	void Update () {
		actual_lv =  PlayerPrefs.GetInt("last_lv_unlock");
		if(PlayerPrefs.GetString("mode") == "DEV")
		{
            PlayerPrefs.SetInt("need_play_annim", 0);
			actual_lv = 7;
		}
		// print(actual_lv);
		int i = 0;
		foreach(GameObject pass in child)
		{
			if (i  + 1 <  actual_lv) // lv _debloquer et fini
			{
				pass.transform.GetComponent<Image>().overrideSprite = approuved;
				pass.GetComponent<Button>().interactable = true;

			}
			else if(i + 1==  actual_lv) // lv debloquer
			{
				pass.transform.GetComponent<Image>().overrideSprite = pending;
				pass.GetComponent<Button>().interactable = true;
                if(PlayerPrefs.GetInt("need_play_annim") == 1)
                {
                    PlayerPrefs.SetInt("need_play_annim", 0);
                    pass.GetComponent<Animation>().Play();
                }
			}
			else if(i +1 >  actual_lv) // lv pas debloquer;
			{
			//print(pass.name);

				pass.transform.GetComponent<Image>().overrideSprite = Waiting_list;
				pass.GetComponent<Button>().interactable = false;
				
			}
			i++;
		}
		
	}
}
