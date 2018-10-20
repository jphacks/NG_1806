﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant_Show : MonoBehaviour {

    public Now_obj num;
    private float grow;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;

    // Update is called once per frame
    void Update () {
        grow = PlayerPrefs.GetInt(num.now + "suc") + PlayerPrefs.GetInt(num.now + "fall") / PlayerPrefs.GetInt(num.now + "for");
        if (grow == 0)
        {
            Debug.Log("Now,0");
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(false);
        }
        else if (grow <(float) 1 / 4)
        {
            Debug.Log("Now,1");
            p1.SetActive(true);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(false);
        }
        else if (grow < (float)2 / 4)
        {
            Debug.Log("Now,2");
            p1.SetActive(false);
            p2.SetActive(true);
            p3.SetActive(false);
            p4.SetActive(false);
        }
        else if (grow < (float)3 / 4)
        {
            Debug.Log("Now,3");
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(true);
            p4.SetActive(false);
        }
        else
        {
            Debug.Log("Now,4");
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(true);
        }
    
}
}