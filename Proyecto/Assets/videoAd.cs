using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoAd : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject musica, corazon, inventario, cartel,pantalla,car,le;
    
    int count = 0;
    void Start()
    {
        le.SetActive(false);

        car.SetActive(false);
        musica.SetActive(false);
       corazon.SetActive(false);
        inventario.SetActive(false);
        cartel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            Destroy(pantalla, 0.3f);
            musica.SetActive(true);
            corazon.SetActive(true);
            inventario.SetActive(true);
            cartel.SetActive(true);
            Destroy(this.gameObject);


        }
        if (!video.isPlaying) {

            count++;
            if (count > 8)
            {
                musica.SetActive(true);
                corazon.SetActive(true);
                inventario.SetActive(true);
                cartel.SetActive(true);
               
                Destroy(this.gameObject);
            }

        }
        else
        {
            Destroy(pantalla,0.3f);
        }
    }
}
