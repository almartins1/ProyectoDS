using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tele : MonoBehaviour
{
    public GameObject carga;
    public GameObject ubica;
    public GameObject letrero;
   
   

    void Start()
    {
        letrero.SetActive(false);
        
        carga.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.T))
            {
                carga.SetActive(true);
                collision.transform.position = ubica.transform.position;

                Destroy(carga, 4f);
                StartCoroutine(Espera(4.1f));
               
                Destroy(this.gameObject, 9f);
            }
        }

    }
    public IEnumerator Espera(float x)
    {
        
        yield return new WaitForSeconds(x);
        letrero.SetActive(true);







    }
}
