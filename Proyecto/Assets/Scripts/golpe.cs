using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpe : MonoBehaviour
{
   public Animator[] anim;
    public GameObject[] colider;
    public int id;
    
    void Start()
    { int count =0;
        foreach(GameObject ga in colider)
        {
            colider[count].SetActive(false);
            count++;
        }
       
         
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "malo")
        {
            int tem = 0;
            int.TryParse(col.transform.GetChild(0).name, out tem);
            colider[tem].SetActive(true);
            anim[tem].SetBool("golpe", true);

            
        }
    }


    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "malo")
        {
            int tem = 0;
            int.TryParse( col.transform.GetChild(0).name ,out tem);
            
            colider[tem].SetActive(false);

            anim[tem].SetBool("golpe", false);


        }
    }
}
