using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coordenadas2 : MonoBehaviour
{
    public Vector2[] lista;
    Dictionary<int, Vector2> coordenadas = new Dictionary<int, Vector2>();
    // Start is called before the first frame update
    int count = 0;
    public Vector2 posicion;
    int count2 = 0;
    public float numeroDeDatos = 10000;
    void Start()
    {
        int limite = ((int)numeroDeDatos);
        lista = new Vector2[limite];
        for (float i = 0; i < numeroDeDatos; i++)
        {
            count2++;
            for (float j = 0; j < numeroDeDatos; j++)
            {
                if (count < lista.Length - 1)
                {
                    lista[count] = new Vector2(count++, j);

                    if (lista[count] ==new Vector2(0, 0))
                    {
                        lista[count] = new Vector2(count2++, j+82);
                    }

                }
                

                count++;

            }
            Debug.Log(count2);
            Debug.Log(posicion + "  posicion");
            Debug.Log(lista[lista.Length-1] +"  lista");

    }
        int mision;
        mision = Random.Range(0, 10000000);
        Vector2 Hola = coordenadas[mision];
        transform.position = Hola;
        

    }

    // Update is called once per frame




}
