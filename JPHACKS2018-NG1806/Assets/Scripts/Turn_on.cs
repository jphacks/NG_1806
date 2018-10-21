using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_on : MonoBehaviour {

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    // Update is called once per frame
    void Update()
    {
        obj2.SetActive(Temp.S_desu);
        obj1.SetActive(!Temp.S_desu);
        obj4.SetActive(Temp.S_desu);
        obj3.SetActive(!Temp.S_desu);
    }
}
