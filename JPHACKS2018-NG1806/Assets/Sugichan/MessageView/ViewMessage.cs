using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using UnityEngine.UI;

public class ViewMessage : MonoBehaviour {

    NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("Messages");
    string m;
    public Text text;
	// Use this for initialization
	void Start () {
        query.WhereEqualTo("Byname", PlayerPrefs.GetString("Name", ""));
       // query.WhereEqualTo("Number", Now_obj.number);
        query.FindAsync((List<NCMBObject> objectlist, NCMBException e) =>
        {
            foreach(NCMBObject message in objectlist)
            {
                m += message["Messages"] + "\n";
            }
            text.text = m;
        }
        );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
