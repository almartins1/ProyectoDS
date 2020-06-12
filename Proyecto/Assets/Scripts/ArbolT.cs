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
    //public int count;
    public int ht;
    public Nodo(int i)
    {
        Dato = i;
        ht = 1;
        //count = 1;
        Izq = null;
        Der = null;
    }
}
public class Tienda
{
    string t = "";
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
       /* else if (current.Dato == value)
        {
            current.count++;
            return current;
        }*/
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
            /*if (raiz.count > 1)
            {
                raiz.count--;
                return raiz;
            }*/
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
   private void inorderRec(Nodo raiz)
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
    int r = 0;
    private string inorderRec2(Nodo raiz)
    {
       


        if (raiz != null)
        {
            inorderRec2(raiz.Izq);

            // MonoBehaviour.print(raiz.Dato + " "+ r++ +"tra");
            r++;
            t +="-"+ raiz.Dato + "  ";
            inorderRec2(raiz.Der);
          
        }
        return t;
    }
    public string inorder2()
    {
       return inorderRec2(raiz);
    }
    public void insert(int i)
    {
        Nodo ae = new Nodo(i);
        if (raiz == null)
        {
            raiz = ae;
        }
        else
        {
            Nodo current = raiz;
            Nodo parent;
            while (true)
            {
                parent = current;
                if (i < current.Dato)
                {
                    current = current.Izq;
                    if (current == null)
                    {
                        parent.Izq = ae;
                        return;
                    }
                }
                else
                {
                    current = current.Der;
                    if (current == null)
                    {
                        parent.Der = ae;
                        return;
                    }
                }
            }
        }
    }
    private int max(int a, int b)
    {
        return (a > b) ? a : b;
    }
    int altura(Nodo N)
    {
        if (N == null)
        {
            return 0;
        }
        return N.ht;
    }  
    Nodo rightRotate(Nodo y)
    {
        Nodo x = y.Izq;
        Nodo T2 = x.Der; 
        x.Der = y;
        y.Izq = T2;
        y.ht = max(altura(y.Izq),altura(y.Der)) + 1;
        x.ht = max(altura(x.Izq),altura(x.Der)) + 1;
        return x;
    }
    Nodo leftRotate(Nodo x)
    {
        Nodo y = x.Der;
        Nodo T2 = y.Izq;
        y.Izq = x;
        x.Der = T2; 
        x.ht= max(altura(x.Izq),altura(x.Der)) + 1;
        y.ht = max(altura(y.Izq),altura(y.Der)) + 1;
        return y;
    }
    int getBalance(Nodo N)
    {
        if (N == null)
        {
            return 0;
        }
        return altura(N.Izq) - altura(N.Der);
    }
    Nodo insert(Nodo node, int key)
    {
        if (node == null)
            return new Nodo(key);
        if (key < node.Dato)
            node.Izq = insert(node.Izq, key);
        else if (key > node.Dato)
            node.Der = insert(node.Der, key);
        else  
            return node;        
        node.ht = 1 + max(altura(node.Izq),altura(node.Der));       
        int balanc = getBalance(node);
 
        if (balanc > 1 && key < node.Izq.Dato)
            return rightRotate(node);
 
        if (balanc < -1 && key > node.Der.Dato)
            return leftRotate(node);
  
        if (balanc > 1 && key > node.Izq.Dato)
        {
            node.Izq = leftRotate(node.Izq);
            return rightRotate(node);
        }
 
        if (balanc < -1 && key < node.Der.Dato)
        {
            node.Der = rightRotate(node.Der);
            return leftRotate(node);
        }

        return node;
    }
    public void añadir(int a)
    {
        raiz = insert(raiz, a);
    }
}



