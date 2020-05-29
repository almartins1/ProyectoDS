using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparicion : MonoBehaviour
{
    public Animator anim;
    public GameObject flecha, letra,boton1, boton2;
    void Start()
    {
        letra.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            boton1.SetActive(true);
            boton2.SetActive(true);
        }
        else
        {
            boton1.SetActive(false);
            boton2.SetActive(false);
        }
    }
    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            letra.SetActive(true);
            flecha.SetActive(false);
            anim.SetBool("dentro", true);
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            letra.SetActive(false);
            flecha.SetActive(true);
            anim.SetBool("dentro", false);
        }
    }

}
