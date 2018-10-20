using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class ViewMessage : MonoBehaviour {

    NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("Message");
    
	// Use this for initialization
	void Start () {
        query.WhereEqualTo("Byname", PlayerPrefs.GetString("Name", ""));
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
