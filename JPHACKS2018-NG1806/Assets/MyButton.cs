using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyButton : MonoBehaviour {

	
    public void OnClick()
    {
        SceneManager.LoadScene("Self_main");
        SceneManager.LoadScene("Self");
        SceneManager.UnloadSceneAsync("MessageView");
    }
}
