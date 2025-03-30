using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidbody;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    [System.Obsolete]
    void Update()
    {
        myRigidbody.velocity = new Vector2(moveSpeed, 0f); // Corrected from linearVelocity to velocity
    }

    [System.Obsolete]
    void OnTriggerEnter2D(Collider2D collision)
    {
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
    }

    [System.Obsolete]
    void FlipEnemyFacing()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidbody.velocity.x)), 1f); // Corrected from linearVelocity to velocity
    }
}