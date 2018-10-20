using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;

public class Scrollview : MonoBehaviour {

    [SerializeField]
    RectTransform prefab;
   /* int a;
    int b;
    int c;
    int[] aa;
    int[] bb;
    
    int[] cc;
	*/
    
    // Use this for initialization
	void Start () {

        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("Cheer");
        query.WhereNotEqualTo("Suc1", "");
        query.OrderByAscending("Suc1");
        query.FindAsync((List<NCMBObject> objectlist, NCMBException e) =>
            {
                foreach(NCMBObject obj in objectlist)
                {
                    var item = GameObject.Instantiate(prefab) as RectTransform;
                    item.SetParent(transform, false);
                    var text = item.GetComponentInChildren<Text>();
                    text.text = (string)obj["Obj1"];
                    var name = item.GetComponentInChildren<Text>();
                    name.text = (string)obj["Name"];
                    var button = item.GetComponentInChildren<Button>();
                }

            }
            );
    /*    
        NCMBQuery<NCMBObject> obj1 = query.WhereNotEqualTo("Suc1", "");
        NCMBQuery<NCMBObject> obj2 = query.WhereNotEqualTo("Suc2", "");
        NCMBQuery<NCMBObject> obj3 = query.WhereNotEqualTo("Suc3", "");
        obj1.OrderByAscending("Suc1");
        obj2.OrderByAscending("Suc2");
        obj3.OrderByAscending("Suc3");


        obj1.FindAsync((List<NCMBObject> objectlist, NCMBException e) =>
        {
            a = objectlist.Count;
            aa = new int[a];
            int aaa = 0;
          foreach(NCMBObject obj in objectlist)
            {
                aa[aaa] =(int)obj["Suc1"];
                aaa++;
            }


        });
        obj2.FindAsync((List<NCMBObject> objectlist, NCMBException e) =>
        {
            b = objectlist.Count;
            bb = new int[b];
            int bbb = 0;
            foreach (NCMBObject obj in objectlist)
            {
                aa[aaa] = (int)obj["Suc1"];
                aaa++;
            }


        });
        */




       


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
