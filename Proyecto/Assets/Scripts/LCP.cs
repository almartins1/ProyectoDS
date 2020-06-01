using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LCP : MonoBehaviour
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
namespace AAAAAA
{
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
    public class ListaMisionesP
    {
        Node cabeza;
        Node tail;
        int countt = 0;
        public ListaMisionesP()
        {
            cabeza = null;
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
            countt -= 1;
        }

        public bool empty()
        {
            return countt == 0;
        }
        public void IngresarCabeza(int aIngresar)
        {
            Node AI = new Node(aIngresar);
            if (!empty())
            {
                Node N2 = cabeza;
                cabeza = AI;
                cabeza.next = N2;
            }
            else
            {
                cabeza = AI;
                tail = AI;
            }
            countt++;
        }
        public int RInicio()      // Metodo para pila (pop)
        {
            Node ANS = cabeza;
            cabeza = cabeza.next;
            countt--;
            return ANS.valor;           
        }
        public int RFinal()   // Metodo para colas (dequeue)
        {
            Node Recorredor = cabeza;
            Node ANS = tail;
            while(Recorredor.next != tail){
                Recorredor = Recorredor.next;
            }
            tail = Recorredor;
            countt--;
            return ANS.valor;
        }
    }
}
