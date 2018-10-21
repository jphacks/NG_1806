using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click_bt : MonoBehaviour {

    public int num;
    public Now_obj ob;

    public void OnClick()
    {
        Temp.number = num;
        Debug.Log(num);
        if (Temp.number == 1)
        {
            if (Account.obj1 == "")
            {
                Debug.Log("goto Objinput");
                SceneManager.LoadScene("Objinput", LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync("Self_main");
                SceneManager.UnloadSceneAsync("Self");
                Temp.nowobjnum = num;
            }
        }
        else if (Temp.number == 2)
        {
            if (Account.obj2 == "")
            {
                Debug.Log("goto Objinput");
                SceneManager.LoadScene("Objinput", LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync("Self_main");
                SceneManager.UnloadSceneAsync("Self");
                Temp.nowobjnum = num;
            }
        }
        else if (Temp.number == 3)
        {
            if (Account.obj3 == "")
            {
                Debug.Log("goto Objinput");
                SceneManager.LoadScene("Objinput", LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync("Self_main");
                SceneManager.UnloadSceneAsync("Self");
                Temp.nowobjnum = num;
            }
        }
    }
}
