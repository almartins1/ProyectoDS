using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace AAAAAA
{
    public class PilaSc : MonoBehaviour
    {
        public Pila lul;
        public Mvv2 mov;
        public ListaMisionesP xd;
        float d = 0;
        int id = 1;
        public bool quitar;
        public GameObject Tpp;
        Dictionary<int, GameObject> aI = new Dictionary<int, GameObject>();
        Dictionary<int, GameObject> ConHash = new Dictionary<int, GameObject>();
        ListaMisionesP Estadoa = new ListaMisionesP();
        public int CR = 3111; 
        public int CA = 4111;
        public int CV = 5111;
        public int health;
        public int numOfH;
        public HashC Hass;
        public GameObject rojo, verde, azul;

        public Image[] Hearts;
        public Sprite FullH;
        public Sprite EmptyH;
        HashC Gemas = new HashC(3);
        void Start()
        {

        }
        private void Update()
        {
            if (health > numOfH)
            {
                health = numOfH;
            }
            for (int i = 0; i < Hearts.Length; i++)
            {
                if (i < health)
                {
                    Hearts[i].sprite = FullH;
                }
                else
                {
                    Hearts[i].sprite = EmptyH;
                }
                if (i < numOfH)
                {
                    Hearts[i].enabled = true;
                }
                else
                {
                    Hearts[i].enabled = false;
                }
            }
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Gemas"))
            {
                other.transform.position = Tpp.transform.position + new Vector3(d, 0.0f, 0.0f);
                other.transform.SetParent(Tpp.transform);
                d += 10;
                other.enabled = false;
                switch (other.gameObject.name)
                {
                    case "Rojo":
                        print("rojo");
                        Gemas.Insertar2(CR);
                        numOfH = numOfH + Gemas.digito2(CR);
                        Estadoa.IngresarCabeza(CR);
                        aI.Add(CR, other.gameObject);
                        CR = CR + 12;
                        break;
                    case "Azul":
                        print("azul");
                        Gemas.Insertar2(CA);
                        Estadoa.IngresarCabeza(CA);
                        aI.Add(CA, other.gameObject);
                        CA = CA + 12;
                        break;
                    case "Verde":
                        print("verde");
                        Gemas.Insertar2(CV);
                        print(mov.mv);
                        mov.mv = mov.mv + (float)Gemas.digito2(CV)*5;
                        print(mov.mv);
                        Estadoa.IngresarCabeza(CV);
                        aI.Add(CV, other.gameObject);
                        CV = CV + 12;
                        break;
                }
                //Estado.push(id);
            }
            if (other.gameObject.CompareTag("F"))
            {
                health--;
                if (!Estadoa.empty())
                {
                    Destroy(other.gameObject);
                    int ttemp = Estadoa.RInicio();                    
                    GameObject temp = aI[ttemp];
                    switch (temp.gameObject.name)
                    {
                        case "Rojo":                            
                            numOfH = numOfH - Gemas.digito2(ttemp);
                            Gemas.remove(ttemp);                            
                            break;
                        case "Verde":
                            mov.mv = mov.mv - Gemas.digito2(ttemp)*5;
                            Gemas.remove(ttemp);
                            break;
                    }
                    Destroy(temp);
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
        
    }
}
