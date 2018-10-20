using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChange : MonoBehaviour
{

    public GameObject confirm;
    public GameObject failed;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Change()
    {
        confirm.SetActive(false);
        failed.SetActive(false);
    }
}
