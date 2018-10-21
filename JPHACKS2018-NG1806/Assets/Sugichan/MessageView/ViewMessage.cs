using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using UnityEngine.UI;

public class ViewMessage : MonoBehaviour {

    NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("Messages");
    public Text text;
    public RectTransform prefab;
	// Use this for initialization
	void Start () {
        query.WhereEqualTo("Byname", PlayerPrefs.GetString("Name", ""));
       // query.WhereEqualTo("Number", Now_obj.number);
        query.FindAsync((List<NCMBObject> objectlist, NCMBException e) =>
        {
            foreach(NCMBObject message in objectlist)
            {
                var item = GameObject.Instantiate(prefab);
                var text = item.GetComponentInChildren<Text>();
                string m = (string)message["Messages"];
                Vector2 v = new Vector2(600, 200 + m.Length * 10);
                item.GetComponent<RectTransform>().sizeDelta = v;
                item.transform.Find("Image"). GetComponent<RectTransform>().sizeDelta = v;
                item.transform.Find("Text").GetComponent<RectTransform>().sizeDelta = v;
                item.SetParent(transform, false);
                text.text = m;
               
            }

        }
        );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
