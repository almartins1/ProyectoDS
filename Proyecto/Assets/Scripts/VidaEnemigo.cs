using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public int life;
    int ataque;
    public vida vida;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
        ataque = vida.ataque;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "arma")
        {
            //Debug.Log("golpe");
            life -= ataque;
        }
    }
}

