using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    public ArrayList arr = new ArrayList();
    int life = 3;
    public GameObject cora1, cora2, cora3;
    void Start()
    {
        arr.Add("tonjeo");
        
        Debug.Log(arr[0]);

    }

    private void FixedUpdate()
    {
        switch (life)
        {
            case 0:
                Destroy(cora1);
                Debug.Log("You Lose");
                new WaitForSeconds(6);
                UnityEngine.Time.timeScale = 0.0f;
                break;

            case 1:
                Destroy(cora2);
                break;

            case 2:
                Destroy(cora3);
                break;


        }
    }
    void Update()
    {
        Debug.Log(life);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("golpe");
            life--;
        }
    }
}
