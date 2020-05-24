using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Nodo
{
    public int Dato;
    public Nodo Izq;
    public Nodo Der;
    public Nodo(int i)
    {
        Dato = i;
        Izq = null;
        Der = null;
    }
}
public class Tienda
{
    Nodo raiz;
    public Tienda()
    {
        raiz = null;
    }
    private Nodo masuno(Nodo current, int value)
    {
        if (current == null)
        {
            return new Nodo(value);
        }

        if (value < current.Dato)
        {
            current.Izq = masuno(current.Izq, value);
        }
        else if (value > current.Dato)
        {
            current.Der = masuno(current.Der, value);
        }
        else
        {
            // RECORDAR CAMBIAR ESTA COSA "count"
            return current;
        }

        return current;
    }
    public void addItem(int valor)
    {
        raiz = masuno(raiz, valor);
    }
    public bool findItem(int id)
    {
        Nodo current = raiz;
        while (current != null)
        {
            if (current.Dato == id)
            {
                return true;
            }
            else if (current.Dato > id)
            {
                current = current.Izq;
            }
            else
            {
                current = current.Der;
            }
        }
        return false;
    }
    
    public Nodo deleteItem(Nodo raiz, int i)
    {
        if(raiz == null)
        {
            return raiz;
        }
        if (i < raiz.Dato) {
            raiz.Izq = deleteItem(raiz.Izq, i);
        }
        if (i > raiz.Dato)
        {
            raiz.Der = deleteItem(raiz.Der, i);
        }
        else
        {
            if (raiz.Izq == null){
                return raiz.Der;
            }
            else if (raiz.Der == null){ 
                return raiz.Izq; 
            }
            Nodo temp = null;
            temp = raiz.Der;
            int minv = temp.Dato;
            while (temp.Izq != null)
            {
                minv = temp.Izq.Dato;
                temp = temp.Izq;
            }
            raiz.Dato = minv;
            raiz.Der = deleteItem(raiz.Der, raiz.Dato);

        }
        return raiz;
    }
    public void AdiosItem(int id)
    {       
        raiz = deleteItem(raiz, id);       
    }
    public void inorderRec(Nodo raiz)
    {
        if (raiz != null)
        {
            inorderRec(raiz.Izq);
            MonoBehaviour.print(raiz.Dato + " ");
            inorderRec(raiz.Der);
        }
    }
    public void inorder()
    {
        inorderRec(raiz);
    }

}

