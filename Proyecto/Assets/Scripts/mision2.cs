using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mision2 : MonoBehaviour
{
    public GameObject enemigo;
    public GameObject musica;
    public GameObject musica2;
    public GameObject letrero, tam;
    public GameObject tetra;
    Stack<GameObject> pila = new Stack<GameObject>();
    public GameObject[] mat;
    private int hecho;
    public VidaEnemigo ene, ene2;
    public SuperTienda yi;
    public GameObject letrero2;
    int mision;
    bool e1, e2,ff;
    void Start()
    {
        ff = true;
        letrero.SetActive(false);
        tetra.SetActive(false);

        letrero2.SetActive(false);
        letrero.SetActive(false);
        enemigo.SetActive(false);

        musica2.SetActive(false);
        foreach (GameObject gam in mat)
        {
            pila.Push(gam);
            pila.Peek().SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (yi.ota && ff)
        {
            letrero.SetActive(true);
            ff = false;
            Destroy(letrero, 6f);
        }
        if (ene2.life <= 0)
        {
            e2 = true;
        }
        if (ene.life <= 0)
        {
            e1 = true;
        }
        if (e2&& e1)
        {
            tetra.SetActive(true);
            letrero2.SetActive(true);
            
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {


            StartCoroutine(Espera());
            enemigo.SetActive(true);
            switch (mision)
            {
                case 0:
                    if (ene.life <= 0 && ene2.life <= 0)
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

                    Destroy(pila.Pop(), 5f);
                    mision = 1;
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
    public IEnumerator Espera()
    {
     yield return   new WaitForSeconds(4.1f);

        tam.SetActive(true);
    }
}
