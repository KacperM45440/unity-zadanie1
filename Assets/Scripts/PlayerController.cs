using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float strength = 1;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //rb.AddForce(new Vector2(0, strength), ForceMode2D.Impulse);
            rb.velocity = Vector2.up * strength;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        GameManager.Instance.OnGameOver();
    }
}
