using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private float swiftness = 3;
    private bool facingRight = true; // Initialize facing direction
    private RaycastHit2D hit;
    private Vector3 moveDelta;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        // Movements
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        moveDelta = new Vector3(x * swiftness, y * swiftness, 0);

        // Facing direction
        if (x < 0)
        {
            facingRight = false;
        }
        else if (x > 0)
        {
            facingRight = true;
        }

        // Set scale based on facing direction
        if (facingRight)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        // Move horizontally
        MoveHorizontally();

        // Move vertically
        MoveVertically();
    }

    private void MoveHorizontally()
    {
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
        }
    }

    private void MoveVertically()
    {
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }
    }
}
