using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemaP : MonoBehaviour
{
    private float cc = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Gemas")
        {
            print("Si");
            Destroy(other.gameObject);
        }
    }
}
