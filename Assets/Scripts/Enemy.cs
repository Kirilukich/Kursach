using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float jumpForce = 15f;
    private bool isGrounded = false;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = transform.GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        float x = Mathf.PingPong(Time.time, 5);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }

}
