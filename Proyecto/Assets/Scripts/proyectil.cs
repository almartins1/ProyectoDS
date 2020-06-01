using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public float velocidad = 10f;
    public GameObject pro;
    public int x, y;
    public proyectil pros;

    void Start()
    {
        x = pros.x;
        y = pros.y;
        

    }

    // Update is called once per frame
    void Update()
    {
        
        
       
        switch (x)
        {
            case -1:
                transform.rotation =  Quaternion.Euler(0f, 0f, 90f);
                break;

            case 1:
                transform.rotation = Quaternion.Euler(0, 0, -90);
                break;

            case 0:
                if (y == 1)
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, 0, 180);
                }
                break;
        }
    }

    private void FixedUpdate()
    {

        transform.Translate(0,  velocidad * Time.deltaTime, 0);
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
