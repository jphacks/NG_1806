using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecideName : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject confirm;
    public void SaveName()
    {

        PlayerPrefs.SetString("Name", GetComponent<InputField>().text);
        PlayerPrefs.Save();
        print(PlayerPrefs.GetString("Name",""));
        confirm.SetActive(true);
    }
}
