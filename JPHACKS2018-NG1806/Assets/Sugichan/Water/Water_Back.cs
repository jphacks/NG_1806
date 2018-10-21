using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water_Back : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Back()
    {
        Temp.S_desu = true;
        SceneManager.LoadScene("Self_main", LoadSceneMode.Additive);
        SceneManager.LoadScene("Self", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Water");
    }
}
