using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float MaxSpeed;
    private Vector2 newVelocity;
    private Rigidbody2D colliderRb;
    public float ballSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        newVelocity = Vector2.one * 4;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + (Vector3)newVelocity * Time.fixedDeltaTime*ballSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 inDirection = newVelocity;
        Vector2 inNormal = collision.contacts[0].normal;
        newVelocity = Vector2.Reflect(inDirection, inNormal);
        newVelocity.Normalize();
        newVelocity *= 4;
        if (collision.rigidbody != null)
        {
            colliderRb = collision.rigidbody;
            newVelocity += colliderRb.velocity * 10;
            ballSpeed += 0.1f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "DeadZone")
        {
            Destroy(this.gameObject);
        }

    }
}
