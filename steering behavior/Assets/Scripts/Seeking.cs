using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeking : MonoBehaviour, IPushble
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float maxSpeed;
    

   
    public void Push(Vector2 direction)
    {
        if (rb.velocity.magnitude > maxSpeed)
            rb.velocity = rb.velocity.normalized * maxSpeed;
        rb.velocity += direction * speed ;
        transform.up = rb.velocity;
    }
}