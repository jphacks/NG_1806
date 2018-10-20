using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
public class Cheerup : MonoBehaviour {


        NCMBObject cheer = new NCMBObject("Cheer");
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public InputField InputField;
    public void cheering()
    {
        var message = InputField.text;
        cheer["message"] = message;
        cheer.SaveAsync();

    }
}
