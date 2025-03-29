using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [System.Obsolete]
    [SerializeField] float runSpeed = 10f;
    Vector2 moveInput;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    [System.Obsolete]
    void Update()
    {
        Run();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
    [System.Obsolete]
    void Run()
    {
        Vector2 playerVelocity = new Vector2 (moveInput.x * runSpeed, rb.velocity.y);   
        rb.velocity = playerVelocity;
    }
}
