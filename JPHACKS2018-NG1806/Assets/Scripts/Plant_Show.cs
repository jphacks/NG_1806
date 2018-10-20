using System.Collections;
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
        if (Temp.S_desu == false)
        {
            grow = (Temp.look_suc + Temp.look_fall) / Temp.look_forfor;
        }
        else if(Now_obj.number == 1)
        {
            grow = (Account.suc1 + Account.fall1) / Account.forfor1;
        }else if(Now_obj.number == 2)
        {
            grow = (Account.suc2 + Account.fall2) / Account.forfor2;
        }else
        {
            grow = (Account.suc3 + Account.fall3) / Account.forfor3;
        }

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
