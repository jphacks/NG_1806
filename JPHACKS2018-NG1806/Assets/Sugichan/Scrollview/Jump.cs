using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        Temp.S_desu = false;
        SceneManager.LoadScene("Other", LoadSceneMode.Additive);
        SceneManager.LoadScene("Self_main", LoadSceneMode.Additive);
        var info = GetComponent<Info>();
        Temp.look_name = info.sendname;
        Temp.sendname = info.sendname;
        Temp.look_obj = info.obj;
        Temp.nowobjnum = info.objnum;
        Temp.look_suc = info.suc;
        Temp.look_fall = info.fall;
        Temp.look_forfor = info.forfor;
        Temp.look_water = info.water;
        SceneManager.UnloadSceneAsync("ScrollView");

    }
}
