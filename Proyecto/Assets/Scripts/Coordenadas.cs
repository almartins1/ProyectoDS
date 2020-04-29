using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;


public class Coordenadas : MonoBehaviour
{
    public LArray aaaa;
    public ListaMisiones listamisiones;    
    int punto =0;   
    [SerializeField] GameObject Flag;
    Dictionary<int, Vector2> coordenadas = new Dictionary<int, Vector2>();
    int count = 1;
    Vector2 posi;
    ListaMisiones pack = new ListaMisiones();
    public int a;
    public int b;
    private int mision;
    public Text puntos;
    public GameObject ubicacion;
    public GameObject sonido;
    public GameObject este;
    public bool laHizo;
    public GameObject boton;
    LArray llol;
    private void Update()
    {
        string puntaje ="objetvo en:  "+ ubicacion.transform.position+ "  "+ "Puntaje es " + punto;
        puntos.text = puntaje; 
    }
    void Start()
    {
        laHizo = true;
        Flag.gameObject.SetActive(false);
        mision = Random.Range(0, a * b);
        este.SetActive(false);
        llol = new LArray(a * b);
        float timeNow = Time.realtimeSinceStartup;
        print(timeNow);
        for (float i = 0; i < a; i++)
            {
            for (float j = 0; j < b; j++)
            {
                 posi = new Vector2(i, j);
                 coordenadas.Add(count, posi);
                 //llol.push(count);                         //Esto es para Listas con arreglos
                 pack.InsertarMision(count);              //Esto es para listas enlazadas
                count++;
                }
            }
        float timeNow2 = Time.realtimeSinceStartup;
        print(timeNow2);
}

    public void OnTriggerEnter2D(Collider2D col)
    {
        

        if (col.tag == "Player") {
            punto++;
            Instantiate(sonido);
           
            este.SetActive(true);
            ubicacion.SetActive(false);
            print(mision + "Esta es la id");
            float timeNow = Time.realtimeSinceStartup;
            print(timeNow);
            pack.EliminarM(mision);                    //Esto es para listas enlazadas
            //llol.delete(mision);                         //Esto es para Listas con arreglos
            float timeNow2 = Time.realtimeSinceStartup;
            print(timeNow2);
            laHizo = true;          
        }

    }

    public void dadorDeMisiones()
    {
        boton.SetActive(false);
        ubicacion.SetActive(true);
        mision = Random.Range(1, a * b);
        print(mision + "Esta es la id");
        float timeNow = Time.realtimeSinceStartup;
        print(timeNow);
        if (pack.BuscaMisiones(mision))                       //Esto es para listas enlazadas
        {
            Vector2 Hola = coordenadas[mision];
            transform.position = Hola;
            Flag.gameObject.SetActive(true);           
        }
        float timeNow2 = Time.realtimeSinceStartup;
        print(timeNow2);
        /*
        float timeNow = Time.realtimeSinceStartup;
        print(timeNow);
        if (llol.search(mision))                                //Esto es para Listas con arreglos
        {
            Vector2 Hola = coordenadas[mision];
            transform.position = Hola;
            Flag.gameObject.SetActive(true);            
        }
        float timeNow2 = Time.realtimeSinceStartup;
        print(timeNow2);
        */
  
        print(coordenadas[mision] + " cordenadas de verdad");
        print(count + " el count");        
        laHizo = false;

    }
}
    
    