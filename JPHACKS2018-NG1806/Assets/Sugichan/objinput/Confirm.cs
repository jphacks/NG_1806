using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Confirm : MonoBehaviour {

    public Text text;
    public InputField inp;
    public InputField by;
	// Use this for initialization
	void Start () {
        text.text = "「" + inp.text + "」" + "という目標を" + "\n" + Regex.Replace(by.text, @"[^0-9]", "") + "日間継続するということで良いですか?";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
