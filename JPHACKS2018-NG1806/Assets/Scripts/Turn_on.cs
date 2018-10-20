using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_on : MonoBehaviour {

    public GameObject obj1;
    public GameObject obj2;
    // Update is called once per frame
    void Update()
    {
        obj2.SetActive(Temp.S_desu);
        obj1.SetActive(!Temp.S_desu);
    }
}
