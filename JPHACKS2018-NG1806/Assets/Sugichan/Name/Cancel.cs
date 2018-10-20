using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cancel : MonoBehaviour {

    public GameObject confirm;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CancelName()
    {
        confirm.SetActive(false);

    }
}
