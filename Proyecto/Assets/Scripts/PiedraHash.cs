using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiedraHash : MonoBehaviour
{
    public HashC XD;
    HashC l = new HashC(3);
    int c = 0;
    // Start is called before the first frame update
    void Start()
    {
        /*l.InsertarObj(2);
        l.InsertarObj(5);
        l.InsertarObj(8);
        l.InsertarObj(4);
        l.InsertarObj(123);
        l.InsertarObj(22);
        l.get(149);
        l.get(2);
        l.remove(2);
        l.get(2);
        l.imp(2);
        l.InsertarObj(2);
        l.imp(2);
        l.imp(1);
        l.imp(3);*/
        float timeNow1 = Time.realtimeSinceStartup;
        print(timeNow1);
        while (c < 10000){           
            l.InsertarObj(c);
            c++;
            
        }
        float timeNow2 = Time.realtimeSinceStartup;
        print(timeNow2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
