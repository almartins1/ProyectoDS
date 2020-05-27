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
    int Valor;
    public NodoObj next;
    public NodoObj(int n)
    {
        Valor = n;
        next = null;
    }
}
public class HashC
{
    NodoObj[] TipoObj;
    int Ocupado = 0;
    int Tamaño;
    public HashC(int capacidad)
    {
        Tamaño = capacidad;
        TipoObj = new NodoObj[capacidad];
    }

    public int IndiceObj(int Id)
    {
        int ObjID;
        ObjID = Id % Tamaño;
        return ObjID;
    }
    public void InsertarObj(int N)
    {
        int indx = IndiceObj(N);
        NodoObj a = new NodoObj(N);
        if(TipoObj[indx]== null)
        {
            TipoObj[indx] = a;
        }
        else
        {          
            while (TipoObj[indx].next != null)
            {
                TipoObj[indx] = TipoObj[indx].next;
            }
            TipoObj[indx].next = a;
        }
    }
}
