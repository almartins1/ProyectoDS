using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
	public float hor, ver;
	public float sped = 1;
	Rigidbody2D rbd;
    private  Animator anim;
    public InputField inputField;
    public GameObject shop,target;
    private bool shopActive;
    public proyectil tap;


    public void Start()
    {
        shop.SetActive(false);
    }
    void Awake()
	{

		rbd = GetComponent<Rigidbody2D>(); //Llamo el rigidbody que ya he creado
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
           
        hor = Input.GetAxisRaw("Horizontal");
		ver = Input.GetAxisRaw("Vertical");



    }
    void FixedUpdate()
    {
       /* if (  Input.GetKeyDown(KeyCode.E)){
            if (!shopActive)
            {
                shop.SetActive(true);

                shopActive = true;

            }
            else {
                shop.SetActive(false);

                shopActive = false;

            }
            

        }*/

        rbd.velocity = new Vector2(hor * sped, ver * sped);

        if(hor==0 && ver == 0)
        {
            anim.SetBool("move", false);
        }
        else
        {
            anim.SetBool("move", true);
        }

        if (hor >= 0.1)
        {
            tap.x = 1;
            tap.y = 0;
            anim.SetBool("abajo", false);
            anim.SetBool("izquierda", false);
            anim.SetBool("arriba", false);

            anim.SetBool("derecha", true);
        }
         if(hor <= -0.1)
        {
            tap.x = -1;
            tap.y = 0;
            anim.SetBool("derecha", false);
            anim.SetBool("abajo", false);
            anim.SetBool("arriba", false);
            anim.SetBool("izquierda", true);
        }
        if(ver >= 0.1)
        {
            tap.y = 1;
            tap.x = 0;
            anim.SetBool("derecha", false);
            anim.SetBool("izquierda", false);
            anim.SetBool("abajo", false);
            anim.SetBool("arriba", true);
        }
         if(ver <= -0.1)
        {
            tap.y = -1;
            tap.x = 0;
            anim.SetBool("derecha", false);
            anim.SetBool("izquierda", false);
            anim.SetBool("arriba", false);
            anim.SetBool("abajo", true);
        }

        
    }

    


}
