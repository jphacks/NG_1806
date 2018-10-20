using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameConfirm : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
        GetComponent<Text>().text = "「"+Account.myname+"」" + "でよろしいですか?";
	}
}
