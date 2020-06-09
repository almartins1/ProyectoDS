    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Disparos : MonoBehaviour
{
    public GameObject proyectilePso,shop;
    public Shop tienda;
    public float tiempo = 0.5f;
    public float lapso = 0;
    int flecha = 7;
   public int coin = 0;
    public GameObject[] tipos = new GameObject[4];
    public  string tipo="normal";
    public Queue cola= new Queue(100);
    public Text dinero;
    void Start()
    {
        int.TryParse(dinero.text, out coin);
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    public void ParaFlechas(string di)
    {
        
        int.TryParse(dinero.text, out coin);

        switch (di)
        {
            case "hielo":
                if (coin >= 150) {
                    cola.enqueue(1);
                    flecha++;
                    coin -= 150;
                }
                else
                {
                    StartCoroutine(tienda.Espera());
                }
                   
                break;
            case "normal":
                if (coin >= 150)
                {
                    cola.enqueue(0);
                    flecha++;
                    coin -= 150;
                }
                else
                {
                    StartCoroutine(tienda.Espera());
                }
                break;
            case "rayo":
                if (coin >= 150)
                {
                    cola.enqueue(3);
                    flecha++;
                    coin -= 150;
                }
                else
                {
                    StartCoroutine(tienda.Espera());
                }
                break;
            case "fuego":
                if (coin >= 150)
                {
                    cola.enqueue(2);
                    flecha++;
                    coin -= 150;
                }
                else
                {
                    StartCoroutine(tienda.Espera());
                }
                break;
        }
        dinero.text = coin + "";
    }

    private void FixedUpdate()
    {
        //Debug.Log(tipo +"  " +flecha);


        lapso += Time.deltaTime;

        if (Input.GetButton("Fire1") && lapso > tiempo && flecha > 0&& shop.activeSelf==false)
        {
            
            switch (tipo)
            {
                default:
                    Instantiate(tipos[0], proyectilePso.transform.position, proyectilePso.transform.rotation);

                    break;

                case "hielo":
                    Instantiate(tipos[1], proyectilePso.transform.position, proyectilePso.transform.rotation);
                    break;


                case "fuego":
                    Instantiate(tipos[2], proyectilePso.transform.position, proyectilePso.transform.rotation);
                    break;


                case "rayo":
                    Instantiate(tipos[3], proyectilePso.transform.position, proyectilePso.transform.rotation);
                    break;
            }


            switch (cola.dequeue())
            {
                case 1:
                    tipo = "hielo";
                    break;
                case 2:
                    tipo = "fuego";
                    break;
                case 3:
                    tipo = "rayo";
                    break;
                case 0:
                    tipo = "normal";
                    break;
            }
            Debug.Log(tipo);



            lapso = 0;

            flecha--;
        }

    }
       
    
}
