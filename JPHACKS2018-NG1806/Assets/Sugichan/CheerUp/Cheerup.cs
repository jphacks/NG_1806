using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
public class Cheerup : MonoBehaviour {


        NCMBObject message = new NCMBObject("Message");
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
        message["message"] = message;
        message["byname"] = SendInfo.name;
        message["number"] = SendInfo.number;
        message.SaveAsync();
        completed.SetActive(true);

    }
}
