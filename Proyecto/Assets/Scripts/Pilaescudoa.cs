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
        public vida vida;
        public bool quitar;
        public GameObject Tpp, rojo, verde, azul;
        Dictionary<int, GameObject> aI = new Dictionary<int, GameObject>();
        //Pila Estado = new Pila(3);
        ListaMisionesP Estadoa = new ListaMisionesP();
        // Start is called before the first frame update
        //public BoxCollider2D ab;
        void Start()
        {

        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Gemas"))
            {
                //other.transform.position = Tpp.transform.position + new Vector3(d, 0.0f, 0.0f);
                //other.transform.SetParent(Tpp.transform);
                switch (other.gameObject.name)
                {
                    case "Roja":
                        aI.Add(id, Instantiate(rojo, Tpp.transform, Tpp.transform));
                        break;
                    case "Azul":
                        aI.Add(id, Instantiate(azul, Tpp.transform, Tpp.transform));
                        break;
                    case "Verde":
                        aI.Add(id, Instantiate(verde, Tpp.transform, Tpp.transform));
                        break;
                }

                d += 10;
                other.enabled = false;

                //Estado.push(id);
                Estadoa.IngresarCabeza(id);
                id++;
                print(id);
                Destroy(other.gameObject);
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
            Debug.Log(vida.col+ "  rar");
            if (quitar)
            {
                if (!Estadoa.empty())
            {
                  /* switch (aI[Estadoa.RInicio()].name)
                    {
                        case "Roja":
                            
                            break;
                        case "Azul":
                          
                            break;
                        case "Verde":
                           
                            break;
                    }*/
                    Destroy(aI[Estadoa.RInicio()]);
                d -= 10;
                quitar = false;

            }
            else
            {
                Debug.Log("demtro;");
            }
                
            }
        }
        public void Quitar()
        {
            
            
                
        }
    }
}
