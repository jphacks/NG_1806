using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using UnityEngine.SceneManagement;

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
        query.WhereNotEqualTo("Suc1", 0);
        query.OrderByAscending("Suc1");
        query.FindAsync((List<NCMBObject> objectlist, NCMBException e) =>
            {
                

                foreach(NCMBObject obj in objectlist)
                {
                    var item = GameObject.Instantiate(prefab) as RectTransform;
                    item.SetParent(transform, false);
                    var t = item.transform.Find("Title");
                    var title=t.GetComponent<Text>();
                    title.text= (string)obj["Obj1"];
                    var n = item.transform.Find("Name");
                    var name = n.GetComponent<Text>();
                    name.text = (string)obj["Name"];
                    var button = item.transform.Find("Button").gameObject;
                    var info = button.GetComponent<Info>();
                    info.sendname = (string)obj["Name"];


                   // button.GetComponent<Info>().sendname =(string)obj["Name"];
                     info.obj = (string)obj["Obj1"];
                     info.objnum = 1;
                     info.forfor = (long)obj["For1"];
                    
                    
                     info.suc =  (long)obj["Suc1"];
                     info.fall = (long)obj["Fall1"];
                    print(obj["Water1"].GetType());
                    info.water = (long)obj["Water1"];
                    



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
