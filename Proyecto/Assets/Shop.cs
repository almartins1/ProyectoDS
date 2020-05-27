using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Globalization;
public class Shop : MonoBehaviour
{
    public vida vida;
    public GameObject[] objetos=new GameObject[16];
    public Dictionary<int, GameObject> diccionario = new Dictionary<int, GameObject>();
    public Text dinero;
    public GameObject x;
    void Start()
    {
        InsertandoALDiccionario();

        x.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void alfabetico(int letra)
    {
        switch (letra)
        {
            case 1:
                Debug.Log("lo logre");
                break;


            case 2:
                Debug.Log("lo logre pero en el 2");
                break;


            case 3:
                Debug.Log("lo logre");
                break;


            case 4:
                Debug.Log("lo logre");
                break;

            case 5:
                Debug.Log("lo logre");
                break;

            case 6:
                Debug.Log("lo logre");
                break;


            case 7:
                Debug.Log("lo logre");
                break;


            case 8:
                Debug.Log("lo logre");
                break;
            case 9:
                Debug.Log("lo logre");
                break;

            case 10:
                Debug.Log("lo logre");
                break;
            case 11:
                Debug.Log("lo logre");
                break;
            case 12:
                Debug.Log("lo logre");
                break;
            case 13:
                Debug.Log("lo logre");
                break;
            case 14:
                Debug.Log("lo logre");
                break;
            case 15:
                Debug.Log("lo logre");
                break;
            case 16:
                Debug.Log("lo logre");
                break;
            case 17:
                Debug.Log("lo logre");
                break;
            case 18:
                Debug.Log("lo logre");
                break;
            case 19:
                Debug.Log("lo logre");
                break;
            case 20:
                Debug.Log("lo logre");
                break;
            case 21:
                Debug.Log("lo logre");
                break;
            case 22:
                Debug.Log("lo logre");
                break;
            case 23:
                Debug.Log("lo logre");
                break;
            case 24:
                Debug.Log("lo logre");
                break;
            case 25:
                Debug.Log("lo logre");
                break;
            case 26:
                Debug.Log("lo logre");
                break;
            
        }
    }

    public void tipo(int tipo)
    {

        switch (tipo)
        {

            case 0:
                foreach (int ind in diccionario.Keys)
                {
                    string nombre = "" + ind;
                    char indexe = char.Parse(nombre.Substring(0, 1));

                    

                        diccionario[ind].SetActive(true);
                   

                }

                break;


            case 1:
                foreach(int ind in diccionario.Keys)
                {
                    string nombre= ""+ind;
                    char indexe = char.Parse(nombre.Substring(0, 1));
                    
                    if (indexe == '1')
                    {
                        
                        diccionario[ind].SetActive(true);
                    }
                    else
                    {
                        diccionario[ind].SetActive(false);
                    }
                    

                }
                
                break;

            case 2:
                foreach (int ind in diccionario.Keys)
                {
                    string nombre = "" + ind;
                    char indexe = char.Parse(nombre.Substring(0, 1));
                    if (indexe == '2')
                    {
                        diccionario[ind].SetActive(true);
                    }
                    else
                    {
                        diccionario[ind].SetActive(false);
                    }


                }
                break;


            case 3:
                foreach (int ind in diccionario.Keys)
                {
                    string nombre = "" + ind;
                    char indexe = char.Parse(nombre.Substring(0, 1));
                    if (indexe == '3')
                    {
                        diccionario[ind].SetActive(true);
                    }
                    else
                    {
                        diccionario[ind].SetActive(false);
                    }


                }
                break;
        }


    }

    public void InsertandoALDiccionario()
    {
        int count =0;
        foreach(GameObject obj in objetos)
        {
            count++;
            string tem = obj.name + count;
            int key = 0;
            int.TryParse(tem, out key);
            diccionario.Add(key, obj);
        }

    }
    public void Accion(int id)
    {
        int precio=0;
        string temp=""+id;
        int.TryParse(temp.Substring(2,temp.Length-2), out precio);
        
        

        int coin;
        int.TryParse(dinero.text, out coin);
        Debug.Log(coin+"  "+ precio);
        if (precio <= coin)
        {
            Debug.Log("casis");
            coin -= precio;

            int.TryParse(temp.Substring(0,1), out vida.ataque);
            int.TryParse(temp.Substring(1, 2), out vida.life);

            dinero.text = coin + "";

        }
        else
        {
            StartCoroutine(Espera());
        }

        



    }

    IEnumerator Espera()
    {
        x.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        x.SetActive(false);


       


        
    }
}
