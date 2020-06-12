using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Globalization;
public class Shop : MonoBehaviour
{
    public vida vida;
    public GameObject[] objetos = new GameObject[16];
    public Dictionary<int, GameObject> diccionario = new Dictionary<int, GameObject>();
    public Tienda reciente = new Tienda();
    public Tienda busc = new Tienda();
    public Disparos disp;
    public GameObject x, sup, player;
    public Inventario inventario;
    public Inventario conver;

    private int contador=0;
    public InputField buscador;
    private GameObject boton;
    Vector3 tra;
    public bool movi=true;

    void Start()
    {
        movi = true;



        InsertandoALDiccionario();

        x.SetActive(false);
        tra = player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        buscar(buscador.text);
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

            case 4:

                foreach (int ind in diccionario.Keys)
                {
                   
                    if (reciente.findItem(ind))
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
            busc.añadir(key);
        }

    }

   public void buscar(string tapi)
    {

        

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {


            movi = false;
        }
        else
        {
            movi = true;
        }

        if (conver.Convertidor(tapi) != 4321)
        {
            foreach (int ob in diccionario.Keys)
            {
                diccionario[ob].SetActive(false);
            }

            if (busc.findItem(conver.Convertidor(tapi)))
            {
                diccionario[conver.Convertidor(tapi)].SetActive(true);
            }
        }
       /* else
        {
            foreach (int ob in diccionario.Keys)
            {
                diccionario[ob].SetActive(true);
            }
        }*/
       


    }

    public void Accion(int id)
    {
       
        int x = 0;
        Debug.Log(diccionario[11]);
        int precio = 0;
        string temp = "" + id;
        
        if (temp.Length > 7)
        {
            x = 1;
        }
            int.TryParse(temp.Substring(4+x,temp.Length-4 -(x * 2)), out precio);
        
         
        Debug.Log(inventario.Slots.Length);
         if (precio <= disp.coin)
         {
            
            for (int i=0; i < inventario.Slots.Length; i++)
             {

                 if (!inventario.lleno[i])
                 {
                   

                    inventario.lleno[i] = true;
                    int otroTem = 0;
                    int.TryParse(temp.Substring(0, 2 + x), out otroTem);
                    reciente.añadir(otroTem);
                    contador++;
                    string xt = reciente.inorder2();
                    Debug.Log(xt +"eeeee");
                    GameObject game=sup;
                    game.transform.position = inventario.Slots[i].transform.position;
                    game.transform.SetParent(inventario.Slots[i].transform);


                    Instantiate(diccionario[otroTem], game.transform, false).transform.SetParent(inventario.Slots[i].transform);
                    diccionario[otroTem].SetActive(false);


                    

                     int.TryParse(temp.Substring(2 + x, 3 + x), out vida.ataquene);
                    Debug.Log(temp.Substring(2 + x, 3 + x)+"terr");
                    int.TryParse(temp.Substring(3 + x, 4 - x  ), out vida.life);
                    disp.coin -= precio;
                    disp.dinero.text = disp.coin + "";
                  
                    break;

                }

                

            }
             //Debug.Log("casis");
           // Debug.Log(disp.coin+"    "+precio);
            



        }
        else
         {
             StartCoroutine(Espera());
         }




     
    }

    public IEnumerator Espera()
    {
        x.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        x.SetActive(false);


       


        
    }
}
