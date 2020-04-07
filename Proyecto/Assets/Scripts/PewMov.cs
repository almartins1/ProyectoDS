using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewMov : MonoBehaviour
{
	public float spedd;
	Rigidbody2D a;
    // Start is called before the first frame update
    void Start()
    {
        a.velocity = transform.right*spedd;
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
