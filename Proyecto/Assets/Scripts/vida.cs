using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    public ArrayList arr = new ArrayList();
    public int life = 800;
    public int ataquene=2;
    public int ataque=4;
    public int vidaEne=8;
 
    public GameObject cora1, cora2, cora3;
    void Start()
    {

       
        
    }

    private void FixedUpdate()
    {
        Debug.Log(ataquene);
        switch (life)
        {
            case 0:
                cora1.SetActive(false);
                cora2.SetActive(false);
                cora3.SetActive(false);

                Debug.Log("You Lose");
                new WaitForSeconds(6);
                UnityEngine.Time.timeScale = 0.0f;
                break;

            case 2:
                cora1.SetActive(true);
                cora2.SetActive(false);
                cora3.SetActive(false);
                break;

            case 4:
                cora1.SetActive(true);
                cora2.SetActive(true);
                cora3.SetActive(false);
                break;

            case 6:
                cora3.SetActive(true);
                cora3.SetActive(true);
                cora3.SetActive(true);
                break;


        }
    }
    void Update()
    {
        if (vidaEne <= 0)
        {
            Destroy(this.gameObject.transform.parent);
        }
        Debug.Log(this.gameObject.transform.parent.name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("golpe");
            life-=ataquene;
        }

       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("golpe");
            life -= ataquene;
        }

       
    }
}
