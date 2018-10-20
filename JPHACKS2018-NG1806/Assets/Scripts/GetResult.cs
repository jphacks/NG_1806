using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GetResult : MonoBehaviour {

    public UnityEngine.UI.Text text;
    public Now_obj no;

    void Update () {
        if(Temp.S_desu == false)
        {
            text.text = (Temp.fall + Temp.suc).ToString() + "days / " + Temp.forfor.ToString() + "days";
        }
        else
        {
            //text.text = 
        }
	}
	
	
}
