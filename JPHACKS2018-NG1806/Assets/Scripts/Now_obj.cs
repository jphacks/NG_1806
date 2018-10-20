using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Now_obj : MonoBehaviour {
    public string now;
    public Touch_ob a;
    public Touch_ob b;
    public Touch_ob c;
    public Touch_ob d;
    public Touch_ob e;
    // Use this for initialization
    void Start () {
        now = "C1";
	}

    public void Change(int n)
    {
        now = "C" + n.ToString();
    }

}
