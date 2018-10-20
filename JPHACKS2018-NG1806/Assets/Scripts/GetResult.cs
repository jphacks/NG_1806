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
        else if(Now_obj.number == 1)
        {
            text.text = (Account.fall1 + Account.suc1).ToString() + "days / " + Account.forfor1.ToString() + "days";
        }else if(Now_obj.number == 2)
        {
            text.text = (Account.fall2 + Account.suc2).ToString() + "days / " + Account.forfor2.ToString() + "days";
        }
        else
        {
            text.text = (Account.fall3 + Account.suc3).ToString() + "days / " + Account.forfor3.ToString() + "days";
        }
    }
	
	
}
