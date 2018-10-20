﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;


public class Starting : MonoBehaviour {

	// Use this for initialization
	void Start () {
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("Cheer");
        query.WhereEqualTo("Name", PlayerPrefs.GetString("Name"));
        query.FindAsync((List<NCMBObject> objectlist, NCMBException e) =>
        {
            if (objectlist.Count == 0)
            {

            }
            else
            {
                Account.myname= (string)objectlist[0]["Name"];
                    Account.obj1 = (string)objectlist[0]["Obj1"];
                    Account.obj2 = (string)objectlist[0]["Obj2"];
                    Account.obj3 = (string)objectlist[0]["Obj3"];
                Account.suc1 = (long)objectlist[0]["Suc1"];
                Account.suc2 = (long)objectlist[0]["Suc2"];
                Account.suc3 = (long)objectlist[0]["Suc3"];
                Account.fall1 = (long)objectlist[0]["Fall1"];
                Account.fall2 = (long)objectlist[0]["Fall2"];
                Account.fall3 = (long)objectlist[0]["Fall3"];
                Account.forfor1 = (long)objectlist[0]["For1"];
                Account.forfor2 = (long)objectlist[0]["For2"];
                Account.forfor3 = (long)objectlist[0]["For3"];






            }
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
