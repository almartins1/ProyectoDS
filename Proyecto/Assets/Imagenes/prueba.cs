using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
public class prueba : MonoBehaviour
{
    public Coordenadas cor;
    int sisas = 0;
    public Animator mision;
    bool laHizo=false;
    public GameObject objeto;
    public GameObject cartel;
    public Animator anim;
    private  char[] je;
    private string pp="   d";
    public GameObject ob;
    // Required when Using UI elements.
    string nuevo = "nada";

     void Start()
    {
        ob.gameObject.SetActive(false);
        objeto.gameObject.SetActive(false);
        cartel.gameObject.SetActive(false);
        anim = GetComponent<Animator>();
       mision = GetComponent<Animator>();
        mision.SetBool("nuevo", true);

    }

    // Update is called once per frame
    void Update()
    {
        laHizo = cor.laHizo;
        

    }
    public void OnTriggerExit2D(Collider2D col)
    {

        
        if (col.tag == "Player")
        {

            ob.gameObject.SetActive(false);
            objeto.gameObject.SetActive(false);
            cartel.gameObject.SetActive(false);
            anim.SetBool("adentro", false);
            
            
        }

    }
    public void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log(mision.GetBool("nuevo"));
        sisas++;
        if (col.tag == "Player")
        {
            ob.gameObject.SetActive(true);
            mision.SetBool("nuevo", laHizo);
            cartel.gameObject.SetActive(true);
            


            objeto.gameObject.SetActive(laHizo);

           
            
            
            if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D))
            {


                objeto.gameObject.SetActive(false);
            }

            


            anim.SetBool("adentro", true);

        }
    }


}
