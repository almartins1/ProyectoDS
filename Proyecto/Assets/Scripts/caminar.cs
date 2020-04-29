using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class caminar : MonoBehaviour
{

    public Transform target;
    public float speed;
    public GameObject boton;
    public GameObject cuadro;
    private Vector3 start, end;

    // Use this for initialization
    void Start()
    {
        cuadro.SetActive(false);
        if (target != null)
        {
            target.parent = null;
            start = transform.position;
            end = target.position;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (target != null)
        {
            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);
        }

        if (transform.position == target.position)
        {
            target.position = (target.position == start) ? end : start;
        }
    }


    public void cambiarEsena()
    {
        boton.SetActive(false);
        cuadro.SetActive(true);
        new WaitForSeconds(3);
        SceneManager.LoadScene("Test 2");
    }
}
