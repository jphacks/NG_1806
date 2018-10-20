using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_text : MonoBehaviour {
    public UnityEngine.UI.Text text;
    public Now_obj no;
    // Use this for initialization
    void Update () {
        if (Temp.S_desu == true) { text.text = Temp.look_obj; }
        else if(Now_obj.number == 1)
        {
            text.text = Account.obj1;
        }else if(Now_obj.number == 2)
        {
            text.text = Account.obj2;
        }
        else
        {
            text.text = Account.obj3;
        }
        
    }
}
