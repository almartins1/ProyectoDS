using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordenadas : MonoBehaviour
{
    public ListaMisiones listamisiones;
    public Pila pp;
    public Queue aasd;
    [SerializeField] GameObject Flag;
    Dictionary<int, Vector2> coordenadas = new Dictionary<int, Vector2>();
    // Start is called before the first frame update
    int count = 1;
    Vector2 posi;
    ListaMisiones pack = new ListaMisiones();
    public int a;
    public int b;
    void Start()
    {
        Pila pila = new Pila(a * b);
        Queue Welinton = new Queue(a * b);
        for (float i = 0; i < a; i++)
        {
            for (float j = 0; j < b; j++)
            {
                posi = new Vector2(i, j);
                coordenadas.Add(count, posi);
                pila.push(count);
                Welinton.enqueue(count);
                pack.InsertarMision(count);
                count++;
            }
        }
        int mision;
        mision = Random.Range(0, a * b);
        if (pack.BuscaMisiones(mision))
        {
            Vector2 Hola = coordenadas[mision];
            transform.position = Hola;
            Flag.gameObject.SetActive(true);
        }
        int y = Welinton.dequeue();
        print(y);
        int x = pila.pop();
        print(x);
        print(coordenadas[y]);
        print(coordenadas[x]);
        print(coordenadas[mision]);
        print(count);
    }

    // Update is called once per frame

}
