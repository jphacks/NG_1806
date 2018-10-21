using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GetResult : MonoBehaviour {

    public UnityEngine.UI.Text text;

    void Update () {
        if(Temp.S_desu == false)
        {
            text.text = (Temp.look_fall + Temp.look_suc).ToString() + "days / " + Temp.look_forfor.ToString() + "days";
        }
        else if(Temp.number == 1)
        {
            text.text = (Account.fall1 + Account.suc1).ToString() + "days / " + Account.forfor1.ToString() + "days";
        }else if(Temp.number == 2)
        {
            text.text = (Account.fall2 + Account.suc2).ToString() + "days / " + Account.forfor2.ToString() + "days";
        }
        else
        {
            text.text = (Account.fall3 + Account.suc3).ToString() + "days / " + Account.forfor3.ToString() + "days";
        }
    }
	
	
}
