using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    public GameObject player;
    public GameObject objetivo;

    public void teletrasporte()
    {
        player.transform.position = new Vector2(objetivo.transform.position.x, objetivo.transform.position.y - 40);

        
    }
    
}
