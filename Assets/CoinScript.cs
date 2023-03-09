using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float speed = 1;
    private GameManager managerRef;

    private void Start()
    {
        managerRef = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        managerRef.UpdateScore();
        Destroy(gameObject);
    }
}
