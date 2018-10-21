using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gohome : MonoBehaviour {
	
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
                            Temp.S_desu = true;
                            SceneManager.LoadScene("Self");
                            SceneManager.UnloadSceneAsync("Other");

                        }
                    }
                }
            }
        }
    }
    public void Onpush(){
        Temp.S_desu = true;
        SceneManager.LoadScene("Self",LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Other");
    }

}

