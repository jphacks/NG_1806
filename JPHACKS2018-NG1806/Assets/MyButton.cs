using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyButton : MonoBehaviour {

	
    public void OnClick()
    {
        SceneManager.LoadScene("Self_main",LoadSceneMode.Additive);
        SceneManager.LoadScene("Self",LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("MessageView");
    }
}
