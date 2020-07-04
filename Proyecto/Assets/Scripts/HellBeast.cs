using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellBeast : MonoBehaviour
{
    public Animator anim;
    public GameObject tra,cartel;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player") {
           

            StartCoroutine(Espera(collision.gameObject));
            

        }
    }

    public IEnumerator Espera(GameObject ds)
    {
        anim.SetBool("toca", true);
        cartel.SetActive(true);
        yield return new WaitForSeconds(2f);
        ds.transform.position = tra.transform.position;


        Destroy(this.gameObject);





    }
}
