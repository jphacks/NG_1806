using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_text : MonoBehaviour {
    public UnityEngine.UI.Text text;
    public Now_obj no;
    // Use this for initialization
    void Update () {
        if (Temp.S_desu == true) { text.text = Temp.look_obj; }
        else
        {
          //  text.text = 
        }
        
    }
}
