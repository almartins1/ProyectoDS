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
        public ListaMisionesP a;
        ListaMisionesP w = new ListaMisionesP();

        // Start is called before the first frame update
        void Start()
        {
            Principal.addItem(5000);
            /*Principal.addItem(19);
            Principal.addItem(60);
            Principal.addItem(1);
            print("Inorder traversal of the given tree");
            Principal.inorder();
            Principal.AdiosItem(19);
            print("Inorder traversal of the given tree");
            Principal.inorder();*/
            while (c <= 10000){
                if(c != 5000)
                {
                    Principal.addItem(c);                
                }
                c++;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
