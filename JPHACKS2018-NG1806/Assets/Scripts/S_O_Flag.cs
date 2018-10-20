using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_O_Flag : MonoBehaviour {
    public Temp temp;
    public GameObject obj1;
    public GameObject obj2;

    // Update is called once per frame
    void Update () {
        if (false)
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
        }
        else
        {
            obj1.SetActive(true);
            obj2.SetActive(false);
        }
    }
}
