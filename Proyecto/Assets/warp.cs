using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{
    public GameObject target;
    public Camera camara;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            
            camara.transform.position = new Vector3(-5, -136,-10);
        }
    }
}
