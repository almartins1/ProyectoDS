using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public float velocidad = 10f;
    public GameObject pro;
   
  

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        transform.Translate(0, velocidad * Time.deltaTime, 0);
        Destroy(this.gameObject, 1.5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag != "Player")
        {
            Debug.Log("get");
            Destroy(Instantiate(pro, transform.position, transform.rotation), 0.40f);

            Destroy(this.gameObject);
        }
       

    }
}
