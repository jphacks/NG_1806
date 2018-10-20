using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Return : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject con;
    public Text text;
    public void Re()
    {
        text.enabled = false;
        con.SetActive(false);

    }
}
