using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mision2 : MonoBehaviour
{
    public GameObject enemigo;
    public GameObject musica;
    public GameObject musica2;
    public GameObject letrero;
    Stack<GameObject> pila= new Stack<GameObject>();
    public GameObject[] mat;
    private int hecho;
    public VidaEnemigo ene;
    public SuperTienda yi;
    public GameObject letrero2;
    int mision;

    void Start()
    {
        letrero2.SetActive(false);
        letrero.SetActive(false);
        enemigo.SetActive(false);
        
        musica2.SetActive(false);
        foreach(GameObject gam in mat)
        {
            pila.Push(gam);
            pila.Peek().SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (yi.ota)
        {
           letrero.SetActive(true);
            Destroy(letrero, 6f);
        }
        if (ene.life <= 0)
        {
            letrero2.SetActive(true);
         Destroy( letrero2,4f);
}
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enemigo.SetActive(true);
            switch (mision)
            {
                case 0:
                    if (ene.life <= 0)
                    {
                        hecho = 1;
                        pila.Peek().SetActive(true);
                    }
                    break;
            }
            musica2.SetActive(true);
            musica.SetActive(false);
            
            
            switch (hecho)
            {
                case 1:
                   
                    Destroy(pila.Pop(),5f);
                    mision= 1;
                    hecho = 0;
                    break;
                
            }

            

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            musica.SetActive(true);
            musica2.SetActive(false);
            Destroy(this.gameObject, 9f);
        }
    }

}
