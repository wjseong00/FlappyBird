using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    BoxCollider2D bc;
    Rigidbody2D rb;
    float groundSizeX;
    float speed = 1f;


    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        groundSizeX = bc.size.x;

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }
    
    void Update()
    {
        //그라운드 이미지가 화면 왼쪽으로 사라지면 오른쪽으로 순간이동
        if(transform.position.x < -groundSizeX)
        {
            //다시 오른쪽으로 이동
            Vector2 groundOffset = new Vector2(groundSizeX * 2, 0);
            transform.position = (Vector2)transform.position + groundOffset;

        }
    }
}
