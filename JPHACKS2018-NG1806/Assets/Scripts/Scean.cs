﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scean : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("Self_main", LoadSceneMode.Additive);
	}
	
}