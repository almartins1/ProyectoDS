using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpe : MonoBehaviour
{
   public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "malo")
        {

            anim.SetBool("golpe", true);

            Debug.Log("traaa");
        }
    }


    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "malo")
        {

            anim.SetBool("golpe", false);


        }
    }
}
