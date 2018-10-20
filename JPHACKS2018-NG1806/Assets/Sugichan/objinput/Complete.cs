using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;

public class Complete : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public InputField inp;
    public GameObject by;
    public void comp()
    {
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("Cheer");
        query.WhereEqualTo("Name", PlayerPrefs.GetString("Name"));
        query.FindAsync((List<NCMBObject> objectlist, NCMBException e) =>
        {
            objectlist[0]["Obj" + Temp.nowobjnum] = inp.text;
            objectlist[0]["For" + Temp.nowobjnum] = by.GetComponent<Confirm>().aa;
            objectlist[0]["Suc" + Temp.nowobjnum] =(int) 0;
            objectlist[0]["Fall" + Temp.nowobjnum] = (int)0;
            //objectlist[0]["wowwow"] = 33;
            //objectlist[0]._onSettingValue("Obj" + Temp.nowobjnum, inp.text);
            //objectlist[0]._onSettingValue("For"+Temp.nowobjnum, by.GetComponent<Confirm>().aa);
            objectlist[0].SaveAsync();
            
            
        }
        );
        
    }
}
