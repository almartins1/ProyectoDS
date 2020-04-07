using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	float hor, ver;
	public float sped = 1;
	Rigidbody2D rbd;
	
	
	void Awake()
	{
		rbd = GetComponent<Rigidbody2D>(); //Llamo el rigidbody que ya he creado
	}
    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
		ver = Input.GetAxisRaw("Vertical");
    }
	void FixedUpdate()
	{
		rbd.velocity = new Vector2(hor * sped, ver * sped);
	}
}
