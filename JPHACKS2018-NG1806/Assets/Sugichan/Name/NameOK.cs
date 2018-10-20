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
        query.WhereEqualTo("Name", Account.name);
        query.FindAsync((List<NCMBObject> objectList, NCMBException e) =>
        {
            if (e == null)
            {
        
        cheer["Name"] = Account.name;
        PlayerPrefs.SetString(Account.name, Account.name);
        PlayerPrefs.Save();

            }
            else
            {
                failed.SetActive(true);
            }
        }
        );

    }
}
