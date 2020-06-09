using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AAAAAA
{
    public class TiendaIntento : MonoBehaviour
    {
        public Tienda tienda;
        Tienda Principal = new Tienda();
        int c = 1;
        int aa = 1;
        public ListaMisionesP a;
        ListaMisionesP w = new ListaMisionesP();
        //public AVLTree a;
        //AVLTree PP = new AVLTree();

        // Start is called before the first frame update
        void Start()
        {
            Principal.addItem(25000);
            Principal.addItem(15000);
            Principal.addItem(20000);
            Principal.addItem(10000);
            Principal.addItem(5000);
            Principal.addItem(40000);
            Principal.addItem(30000);
            Principal.addItem(35000);
            Principal.addItem(45000);
            Principal.addItem(50000);
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
            while (c <= 50000){
                if (c % 5000 != 0)
                {
                    Principal.addItem(c);
                }
                c++;
            }
            float timeNow1 = Time.realtimeSinceStartup;
            print(timeNow1);
            Principal.AdiosItem(9999);
            float timeNow3 = Time.realtimeSinceStartup;
            print(timeNow3);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
