using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfH;

    public Image[] Hearts;
    public Sprite FullH;
    public Sprite EmptyH;

    private void Update()
    {
        if(health > numOfH)
        {
            health = numOfH;
        }
        for (int i = 0; i < Hearts.Length; i++)
        {
            if (i < health)
            {
                Hearts[i].sprite = FullH;
            } else
            {
                Hearts[i].sprite = EmptyH;
            }
            if(i < numOfH)
            {
                Hearts[i].enabled = true;
            } else
            {
                Hearts[i].enabled = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("F"))
        {
            health--;
        }
    }
}
