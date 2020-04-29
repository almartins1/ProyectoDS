using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    [SerializeField] GameObject BotonSalida, Canvasxd, Tpi, Tpo, Resumir;
    // Start is called before the first frame update
    void Start()
    {
        BotonSalida.gameObject.SetActive(false);
        Canvasxd.gameObject.SetActive(false);
        Resumir.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.Time.timeScale = 0.0f;
            BotonSalida.gameObject.SetActive(true);
            Canvasxd.gameObject.SetActive(true);
            Resumir.gameObject.SetActive(true);
            Tpi.gameObject.SetActive(false);
            Tpo.gameObject.SetActive(false);
        }
    }
    public void Salidaaaa()
    {
        Application.Quit();
    }
    public void Resumirrrrr() 
    {
        UnityEngine.Time.timeScale = 1.0f;
        BotonSalida.gameObject.SetActive(false);
        Canvasxd.gameObject.SetActive(false);
        Tpi.gameObject.SetActive(true);
        Tpo.gameObject.SetActive(true);
        Resumir.gameObject.SetActive(false);
    }
}
