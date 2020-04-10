using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordenadas : MonoBehaviour
{
    Dictionary<int, Vector2> coordenadas = new Dictionary<int, Vector2>();
    // Start is called before the first frame update
    int count = 0;
    Vector2 posi;
    void Start()
    {
        for(float i = 0; i < 10000; i++)
        {
            for(float j = 0; j <1000; j++)
            {
                posi = new Vector2(i, j);
                coordenadas.Add(count, posi);
                count++;
            }
        }
        int mision;
        mision = Random.Range(0, 10000000);
        Vector2 Hola = coordenadas[mision];
        transform.position = Hola;
        print(coordenadas[mision]);
        print(count);
    }
    
    // Update is called once per frame

}
