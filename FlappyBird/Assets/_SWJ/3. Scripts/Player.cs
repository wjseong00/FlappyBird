using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    int power = 200;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * power);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("죽음");
        GameManager.Instance.gameOver = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("스코어 1추가");
        GameManager.Instance.score++;
        print("Score : " + GameManager.Instance.score);
    }
}
