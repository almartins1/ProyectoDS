using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperTienda : MonoBehaviour
{
    public GameObject shop, music1, music2;
    private bool shopActive;
    public bool ota;

    void Start()
    {
     music2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {

                if (!shopActive)
                {
                    music1.SetActive(false);
                    music2.SetActive(true);


                    shop.SetActive(true);

                    shopActive = true;

                }
                else
                {
                    ota = true;
                    music1.SetActive(true);
                    music2.SetActive(false);

                    shop.SetActive(false);

                    shopActive = false;

                }


            }
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            
        }
    }
}
