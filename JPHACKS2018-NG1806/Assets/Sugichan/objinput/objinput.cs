﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class objinput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public InputField inp;
    public InputField bytime;
    public GameObject con;
    public Text notinput;
    public void OK()
    {
        if (inp.text.Length ==0 || Regex.Replace(bytime.text, @"[^0-9]", "")=="")
        {
            notinput.enabled = true;
        }
        else
        {

        con.SetActive(true);
        }

    }
}
