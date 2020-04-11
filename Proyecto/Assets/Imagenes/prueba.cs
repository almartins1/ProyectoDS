using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class prueba : MonoBehaviour
{
    public InputField jeremy;
    public GameObject objeto;
    public GameObject cartel;
    public Animator anim;
    // Required when Using UI elements.
    string nuevo = "nada";

    void Start()
    {
        objeto.gameObject.SetActive(false);
        cartel.gameObject.SetActive(false);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            objeto.gameObject.SetActive(false);
            cartel.gameObject.SetActive(false);
            anim.SetBool("adentro", false);
        }

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            cartel.gameObject.SetActive(true);
            objeto.gameObject.SetActive(true);
            anim.SetBool("adentro", true);

        }
    }


}
