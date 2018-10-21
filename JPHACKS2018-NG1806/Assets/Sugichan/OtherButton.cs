using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        SceneManager.LoadScene("CheerUp",LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Self_main");
        SceneManager.UnloadSceneAsync("Other");
        Temp.sendname = Temp.look_name;
        Temp.sendnumber = Temp.look_ach;
    }
}
