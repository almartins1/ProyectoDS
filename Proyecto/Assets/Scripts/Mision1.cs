using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mision1 : MonoBehaviour
{
    public GameObject cartel;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            
            
            
            Destroy(cartel);

        }
    }
}
