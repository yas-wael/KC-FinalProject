using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 temp = rb.velocity;

        // running:
        temp.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = temp;

    }
}
