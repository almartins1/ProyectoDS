﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AAAAAA
{
    public class TiendaIntento : MonoBehaviour
    {
        public Tienda tienda;
        Tienda Principal = new Tienda();
        int c = 1;
        public ListaMisionesP a;
        ListaMisionesP w = new ListaMisionesP();

        // Start is called before the first frame update
        void Start()
        {
            Principal.insert(50000);
            /*Principal.addItem(19);
            Principal.addItem(60);
            Principal.addItem(1);
            print("Inorder traversal of the given tree");
            Principal.inorder();
            Principal.AdiosItem(19);
            print("Inorder traversal of the given tree");
            Principal.inorder();*/
            float timeNow2 = Time.realtimeSinceStartup;
            print(timeNow2);
            while (c <= 100000){
                if(c != 50000)
                {
                    Principal.insert(c);                      
                }
                c++;
            }
            float timeNow1 = Time.realtimeSinceStartup;
            print(timeNow1);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
