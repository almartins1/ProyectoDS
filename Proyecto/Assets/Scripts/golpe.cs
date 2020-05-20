using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpe : MonoBehaviour
{
   public Animator anim;
    public GameObject colider;
    void Start()
    {
        colider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "malo")
        {
            colider.SetActive(true);
            anim.SetBool("golpe", true);

           
        }
    }


    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "malo")
        {
            colider.SetActive(false);

            anim.SetBool("golpe", false);


        }
    }
}
