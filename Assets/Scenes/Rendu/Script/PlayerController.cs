using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.WSA;

public class PlayerController : MonoBehaviour
{
    private Vector2 direction = Vector2.zero;
    Rigidbody2D rb;
    [SerializeField] private float speed;
    public GameObject localBall;
    [SerializeField] private GameObject Ball;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Movement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + (Vector3)direction * Time.fixedDeltaTime * speed);
        if (localBall == null)
        {
            localBall = Instantiate(Ball, transform.position + Vector3.up, Quaternion.identity);
        }
    }
}
