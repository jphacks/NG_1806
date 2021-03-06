﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using UnityEngine.SceneManagement;

public class Cheerup : MonoBehaviour {


        NCMBObject message = new NCMBObject("Messages");
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public InputField InputField;
    public GameObject completed;
    public void cheering()
    {
        var mes = InputField.text;
        message["Messages"] = InputField.text;
        message["Byname"] = Temp.sendname;
        message["Number"] = Temp.sendnumber;
        message.SaveAsync();
        completed.SetActive(true);
        StartCoroutine("Back");
    }

    public IEnumerator Back()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("goto ScrollView");
        SceneManager.LoadScene("ScrollView", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("CheerUp");
    }
}
