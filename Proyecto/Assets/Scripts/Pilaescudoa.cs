using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilaescudoa : MonoBehaviour
{
    public Pila lul;
    float d = 0;
    int id = 1;
    public GameObject Tpp;
    Dictionary<int, GameObject> aI = new Dictionary<int, GameObject>();
    Pila Estado = new Pila(3);
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gemas"))
        {
            other.transform.position = Tpp.transform.position + new Vector3(d, 0.0f, 0.0f);
            d += 10;
            aI.Add(id, other.gameObject);
            Estado.push(id);
            id++;
            print(id);
        }
        if (other.gameObject.CompareTag("F"))
        {
            Destroy(other.gameObject);
            Destroy(aI[Estado.pop()]);
            d -= 10;
            other.transform.position = Tpp.transform.position + new Vector3(d, 0.0f, 0.0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
