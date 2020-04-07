using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
	public Transform fire;
	public GameObject pewPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
			pew();
		}
    }
	void pew()
	{
	Instantiate(pewPrefab, fire.position, fire.rotation);
	}
}
