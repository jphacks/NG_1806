using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class NameOK : MonoBehaviour {

    NCMBObject cheer = new NCMBObject("Cheer");
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject failed;
    public void OK()
    {
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("Cheer");
        query.WhereEqualTo("Name", Account.myname);
        query.FindAsync((List<NCMBObject> objectList, NCMBException e) =>
        {
            if (objectList.Count==0)
            {
                cheer["Name"] = Account.myname;
                cheer["Obj1"] = "";
                cheer["Obj2"] = "";
                cheer["Obj3"] = "";
                cheer["Suc1"]= 0;
                cheer["Suc2"]= 0;
                cheer["Suc3"]= 0;
                cheer["Fall1"]= 0;
                cheer["Fall2"]= 0;
                cheer["Fall3"]= 0;
                cheer["For1"]= 0;
                cheer["For2"]= 0;
                cheer["For3"]= 0;
                cheer["Water1"] = 0;
                cheer["Water2"] = 0;
                cheer["Water3"] = 0;

                PlayerPrefs.SetString("Name", Account.myname);
                PlayerPrefs.Save();
                cheer.SaveAsync();

            }
            else
            {
                failed.SetActive(true);
            }
        }
        );

    }
}
