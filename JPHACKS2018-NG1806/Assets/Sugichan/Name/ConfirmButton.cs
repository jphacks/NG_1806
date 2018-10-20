using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public InputField inputField;
    public GameObject confirm;
    public void Confirm()
    {
        Account.name = inputField.text;
        confirm.SetActive(true);
    }
}
