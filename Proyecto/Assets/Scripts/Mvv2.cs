using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mvv2 : MonoBehaviour
{
    public float mv = 5f;
    public Rigidbody2D rb;
    Vector2 move;
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * mv * Time.fixedDeltaTime);
    }
}
