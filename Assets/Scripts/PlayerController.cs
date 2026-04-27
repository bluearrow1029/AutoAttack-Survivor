using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 5f;

    Rigidbody2D rb;
    Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(x, y).normalized;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * _speed * Time.fixedDeltaTime);
    }
}
