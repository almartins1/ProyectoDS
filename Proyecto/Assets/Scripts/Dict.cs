using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dict : MonoBehaviour
{

}
public class Node
{
    public int valor;
    public Node next;

    public Node(int i)
    {
        valor = i;
        next = null;
    }
}
public class ListaMisiones
{
    Node cabeza;
    public ListaMisiones()
    {
        cabeza = null;
    }
    public void InsertarMision(int n)
    {
        /* Node nuevaM = new Node(n);
         if (cabeza == null)
         {
             cabeza = nuevaM;
         }
         else
         {
             Node temp2 = cabeza;
             while (temp2.next != null)
             {
                 temp2 = temp2.next;
             }
             temp2.next = nuevaM;
         }*/
        Node nuevaM = new Node(n);
        nuevaM.next = cabeza;
        cabeza = nuevaM;
    }
    public bool BuscaMisiones(int x)
    {
        Node aMision = cabeza;
        while (aMision != null)
        {
            if (aMision.valor == x)
            {
                return true;
            }
            aMision = aMision.next;
        }
        return false;
    }
    public void ImprimirId(int z)
    {
        Node aImpr = cabeza;
        while (aImpr.valor != z)
        {
            aImpr = aImpr.next;
            if(aImpr.next == null)
            {
                aImpr.valor = 0;
                break;
            }
        }
        MonoBehaviour.print(aImpr.valor);
    }
    public void EliminarM(int y)
    {
        Node Mision = new Node(y);
        Node Cc = cabeza;
        while ((Cc.next).valor != y)
        {
            Cc = Cc.next;
        }
        if (Mision.next == null)
        {
            Cc.next = null;
        }
        else
        {
            Cc.next = Mision.next;
            Mision.next = null;
        }
    }
}



