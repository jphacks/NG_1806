using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Starting()
    {
        if (PlayerPrefs.GetString("Name")==null)
        {
            SceneManager.LoadScene("Name", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Start");
        }
        else
        {

        }
    }
}
