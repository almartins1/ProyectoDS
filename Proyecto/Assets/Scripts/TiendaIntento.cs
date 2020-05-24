using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaIntento : MonoBehaviour
{
    public Tienda tienda;
    Tienda Principal = new Tienda();
    // Start is called before the first frame update
    void Start()
    {
        Principal.addItem(19);
        Principal.addItem(60);
        Principal.addItem(1);
        print("Inorder traversal of the given tree");
        Principal.inorder();
        Principal.AdiosItem(19);
        print("Inorder traversal of the given tree");
        Principal.inorder();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
