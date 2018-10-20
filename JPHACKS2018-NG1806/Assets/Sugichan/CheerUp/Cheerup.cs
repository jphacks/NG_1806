using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using UnityEngine.SceneManagement;

public class Cheerup : MonoBehaviour {


        NCMBObject message = new NCMBObject("Message");
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public InputField InputField;
    public GameObject completed;
    public void cheering()
    {
        var mes = InputField.text;
        message["Message"] = InputField.text;
        message["Byname"] = Temp.sendname;
        message["Number"] = Temp.sendnumber;
        message.SaveAsync();
        completed.SetActive(true);

    }

    public IEnumerator back()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Self_main", LoadSceneMode.Additive);
        SceneManager.LoadScene("Self", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("CheerUp");
    }
}
