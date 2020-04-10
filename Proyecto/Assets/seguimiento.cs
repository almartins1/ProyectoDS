using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimiento : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera camara;
    public Movement objeto;
    private float hor;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        camara = GetComponent<Camera>();
        

    }

    // Update is called once per frame
    void Update()
    {


        camara.transform.Translate((new Vector2(objeto.hor * objeto.sped, objeto.ver * objeto.sped))*Time.deltaTime);
    }
}
