using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hash : MonoBehaviour
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
public class NodoObj
{
    public int valor;
    public NodoObj next;
    public NodoObj(int n)
    {
        valor = n;
        next = null;
    }
}
public class HashC
{
    NodoObj[] TipoObj;
    int Tamaño;
    public HashC(int capacidad)
    {
        Tamaño = capacidad;
        TipoObj = new NodoObj[capacidad];
    }

    public int IndiceObj(int Id)
    {
        return Id % Tamaño;
    }
    public void InsertarObj(int N)
    {
        int indx = IndiceObj(N);
        NodoObj a = TipoObj[indx];
        if (a == null)
        {
            TipoObj[indx] = new NodoObj(N);
        }
        else
        {
            while (a.next != null)
            {
                if(a.valor == N)
                {
                    MonoBehaviour.print("El valor ya esta insertado");
                    return;
                }
                a = a.next;
            }
            a.next = new NodoObj(N);
        }
    }
    public void Insertar2(int N)
    {
        int indx = IndiceObj(N);
        NodoObj temp = TipoObj[indx];
        TipoObj[indx] = new NodoObj(N);
        TipoObj[indx].next = temp;
    }
    public void remove(int k)
    {
        int b = IndiceObj(k);
        NodoObj r = TipoObj[b];
        NodoObj prev = null;
        while(r != null)
        {
            if(r.valor == k)
            {
                break;
            }
            prev = r;
            r = r.next;
        }
        if (r == null)
        {
            MonoBehaviour.print("F");
            return;
        }
        if (prev != null)
        {
            prev.next = r.next;
            return;
        }
        else
        {
            TipoObj[b] = r.next;
            r = null;            
            return;
        }
    }
    public void get(int k)
    {
        int b = IndiceObj(k);
        NodoObj a = TipoObj[b];
        while (a != null)
        {
            if(a.valor == k)
            {
                MonoBehaviour.print("Si esta el numero");
                return;
            }
            a = a.next;
        }
        MonoBehaviour.print("F no esta");
        return;

    }
    public void imp(int k)
    {
        int b = IndiceObj(k);
        NodoObj a = TipoObj[b];
        while(a != null)
        {
            MonoBehaviour.print(a.valor + " ");
            a = a.next;
        }
    }
    public int digito2(int number)
    {
        number = number / 10;
        number = number % 10;
        return number;
    }
}
