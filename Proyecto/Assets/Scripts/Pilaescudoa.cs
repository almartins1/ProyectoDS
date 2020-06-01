using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AAAAAA
{
    public class Pilaescudoa : MonoBehaviour
    {
        public Pila lul;
        public ListaMisionesP xd;
        float d = 0;
        int id = 1;
        public GameObject Tpp;
        Dictionary<int, GameObject> aI = new Dictionary<int, GameObject>();
        //Pila Estado = new Pila(3);
        ListaMisionesP Estadoa = new ListaMisionesP();
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
                //Estado.push(id);
                Estadoa.IngresarCabeza(id);
                id++;
                print(id);
            }
            if (other.gameObject.CompareTag("F"))
            {
                if (!Estadoa.empty())
                {
                    Destroy(other.gameObject);
                    Destroy(aI[Estadoa.RInicio()]);
                    d -= 10;
                    other.transform.position = Tpp.transform.position + new Vector3(d, 0.0f, 0.0f);
                }
                else
                {
                    print("XD");
                    Destroy(other.gameObject);
                }
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
