﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Close_pop : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (0 < Input.touchCount)
        {
            // タッチされている指の数だけ処理
            for (int i = 0; i < Input.touchCount; i++)
            {
                // タッチ情報をコピー
                UnityEngine.Touch t = Input.GetTouch(i);
                // タッチしたときかどうか
                if (t.phase == TouchPhase.Began)
                {
                    //タッチした位置からRayを飛ばす
                    Ray ray = Camera.main.ScreenPointToRay(t.position);
                    RaycastHit hit = new RaycastHit();
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Rayを飛ばしてあたったオブジェクトが自分自身だったら
                        if (hit.collider.gameObject == this.gameObject)
                        {
                            Debug.Log("goto ScrollView");
                            SceneManager.LoadScene("ScrollView", LoadSceneMode.Additive);
                            SceneManager.UnloadSceneAsync("Self_main");
                            SceneManager.UnloadSceneAsync("Other");
                        }
                    }
                }
            }
        }
    }
}
