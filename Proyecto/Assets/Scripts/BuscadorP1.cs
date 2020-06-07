using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuscadorP1 : MonoBehaviour
{
    public Tienda a;
    Tienda Buscador = new Tienda();
    public GameObject Input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Loquem()
    {
        string a;
        a = Input.GetComponent<Text>().text;
        print(a);
    }
}
