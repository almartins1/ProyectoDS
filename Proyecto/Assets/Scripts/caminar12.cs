using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class caminar12 : MonoBehaviour
{

    public Transform target;
    public float speed;
    private Vector3 start, end;
    bool player = false;
    bool x=false;



    // Use this for initialization
    void Start()
    {
        

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
        if (x)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }

        if (!x)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
    }

    void FixedUpdate()
    {
        if (transform.position.x < target.transform.position.x)
        {
            x = false;
        }

        if (transform.position.x > target.transform.position.x)
        {
            x = true;
        }

        if (!player)
        {
            if (target != null)
            {
                float fixedSpeed = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);

            }

            if (transform.position == target.position)
            {
               
              /*  if (x)
                {
                    x = false;
                }
                else
                {
                    x = true;
                }*/
                target.position = (target.position == start) ? end : start;
            }
        }
    }


   

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            player = true;
        }

        if (col.tag == "Player" && player)
        {

            if (transform.position.x < col.transform.position.x)
            {
                x = false;
            }

            if (transform.position.x > col.transform.position.x)
            {
                x = true;
            }


            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, col.transform.position, fixedSpeed);

            

        }
    }


    public void OnTriggerExit2D(Collider2D col)
    {


        if (col.tag == "Player")
        {
            player = false;
        }
    }
}
