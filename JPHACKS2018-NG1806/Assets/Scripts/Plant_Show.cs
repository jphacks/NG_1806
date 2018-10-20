using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant_Show : MonoBehaviour {

    public Now_obj num;
    private float grow;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;

    // Update is called once per frame
    void Update () {
        grow = PlayerPrefs.GetInt(num.now + "suc") + PlayerPrefs.GetInt(num.now + "fall") / PlayerPrefs.GetInt(num.now + "for");
        if (grow == 0)
        {
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
        }
        else if (grow < 1 / 3)
        {
            p1.SetActive(true);
            p2.SetActive(false);
            p3.SetActive(false);
        }
        else if (grow < 2 / 3)
        {
            p1.SetActive(false);
            p2.SetActive(true);
            p3.SetActive(false);
        }
        else
        {
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(true);
        }
    
}
}
