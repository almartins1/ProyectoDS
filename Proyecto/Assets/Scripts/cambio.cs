using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio : MonoBehaviour
{
    public Animator anim;
    public Coordenadas cor;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("nuevo",true);
    }

    // Update is called once per frame
    void Update()
    {
       anim.SetBool("nuevo", cor.laHizo);
    }
}
