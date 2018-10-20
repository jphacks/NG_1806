using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_on : MonoBehaviour {

    public GameObject obj1;
    public GameObject obj2;
    bool now = false;
    // Update is called once per frame
    void Update()
    {
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
                            now = !now;
                            obj2.SetActive(now);
                            obj1.SetActive(now);
                        }
                    }
                }
            }
        }
    }
}
