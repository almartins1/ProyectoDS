using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coordenadas : MonoBehaviour
{
    public ListaMisiones listamisiones;
    public Pila pp;
    int punto =0;
    public Queue aasd;
    [SerializeField] GameObject Flag;
    Dictionary<int, Vector2> coordenadas = new Dictionary<int, Vector2>();
    // Start is called before the first frame update
    int count = 1;
    Vector2 posi;
    ListaMisiones pack = new ListaMisiones();
    public int a;
    public int b;
    int mision;
    public Text puntos;
    public GameObject ubicacion;
    public GameObject sonido;
    public GameObject este;
    public bool laHizo;
    Pila pila;
    Queue Welinton;
    private void Update()
    {
        string puntaje ="objetvo en:  "+ ubicacion.transform.position+ "  "+ "Puntaje es " + punto;
        puntos.text = puntaje; 
    }
    void Start()
    {
        este.SetActive(false);

        pila = new Pila(a * b);
            Welinton = new Queue(a * b);
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
       

    // Update is called once per frame

}

    public void OnTriggerEnter2D(Collider2D col)
    {
        

        if (col.tag == "Player") {
            punto++;
            Instantiate(sonido);
           
            este.SetActive(true);
            ubicacion.SetActive(false);
            laHizo = true;
            

        }

    }

    public void dadorDeMisiones()
    {
        ubicacion.SetActive(true);
        mision = Random.Range(0, a * b);
        if (pack.BuscaMisiones(mision))
        {
            Vector2 Hola = coordenadas[mision];
            transform.position = Hola;
            Flag.gameObject.SetActive(true);
        }
        int y = Welinton.dequeue();
        print(y + " y");
        int x = pila.pop();
        print(x + " x");
        print(coordenadas[y] + " cordenads cola");
        print(coordenadas[x] + " cordenas ppila");
        print(coordenadas[mision] + " cordenadas de verdad");
        print(count + " el count");

        laHizo = false;

    }
}
    
    