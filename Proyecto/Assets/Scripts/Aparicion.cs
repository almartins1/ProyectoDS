using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparicion : MonoBehaviour
{
    public Animator anim;
    public GameObject flecha, letra;
    void Start()
    {
        letra.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
