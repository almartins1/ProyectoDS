using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimiento : MonoBehaviour
{
    public GameObject GO;
    public Camera camara;
    public Movement objeto;
    private float hor;
    TextMesh tx;
    void Start()
    {
        GO = GetComponent<GameObject>();
        camara = GetComponent<Camera>();
        

    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
