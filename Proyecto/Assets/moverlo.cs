using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverlo : MonoBehaviour
{
    public Camera camara;
    public float x;
    public float y;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {

            camara.transform.position = new Vector3(x, y, -10);
        }
    }
}
