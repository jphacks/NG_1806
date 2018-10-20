using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GetResult : MonoBehaviour {

    public UnityEngine.UI.Text text;
    public Now_obj no;

    void Update () {

        text.text = ((PlayerPrefs.GetInt(no.now + "fall") + PlayerPrefs.GetInt(no.now + "suc")).ToString() + "days / "
            + PlayerPrefs.GetInt(no.now + "for").ToString() + "days");
	}
	
	
}
