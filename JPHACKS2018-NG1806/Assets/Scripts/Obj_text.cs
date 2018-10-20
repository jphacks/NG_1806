using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_text : MonoBehaviour {
    public UnityEngine.UI.Text text;
    public Now_obj no;
    // Use this for initialization
    void Update () {
        text.text = PlayerPrefs.GetString(no.now + "obj");

    }
}
