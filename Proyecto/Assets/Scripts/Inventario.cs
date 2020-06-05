using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public bool[] lleno;
    public GameObject[] Slots;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public int Convertidor (string cad){

        switch (cad)
        {
            case "espada":
                return 11;
                break;

            case "maso":
                
                return 12;
                break;

            case "ballesta":
                return 13;
                break;

            case "arco":
                return 14;
                break;

            case "flecha madera":
                return 15;
                break;

            case "flecha fuego":
                return 16;
                break;

            case "flecha hielo":
                return 17;
                break;

            case "flecha rayo":
                return 18;
                break;

            case "escudo":
                return 29;
                break;

            case "casco":
                return 210;
                break;

            case "capa":
                return 211;
                break;

            case "vida":
                return 312;
                break;

            case "libro":
                return 313;
                break;

            case "cuchillos":
                return 114;
                break;

            case "escudo hierro":
                return 215;
                break;

            case "resoltera":
                return 116;
                break;

            case "baston":
                return 117;
                break;

            case "cinturon":
                return 318;
                break;

            case "ataque":
                return 319;
                break;


            default: return 4321;

        }

    }

}
