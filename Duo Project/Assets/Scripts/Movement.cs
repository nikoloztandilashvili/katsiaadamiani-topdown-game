using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    BoxCollider2D boxCollider;
    private float swiftness = 3;
    private bool facingRight;
    private RaycastHit2D hit;
    private Vector3 moveDelta;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {

        //movements
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        moveDelta = new Vector3(x * swiftness, y * swiftness, 0);


        //facingDirection
        if (moveDelta.x < 0)
        {
            facingRight = false;
        }
        else if (moveDelta.x > 0)
        {
            facingRight = true;
        }



        if (facingRight) { transform.localScale = new Vector3(-1, 1, 1); }
        else { transform.localScale = new Vector3(1, 1, 1); }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }


        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
        }


    }
}
