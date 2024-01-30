using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    private float swiftness =3;
    private bool facingRight;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //movements
        float movementy = Input.GetAxis("Vertical");
        float movementx = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movementx * swiftness, movementy * swiftness);

        //facingDirection
        if (Input.GetKeyDown(KeyCode.A))
        {
            facingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            facingRight = true;
        }
        else if (Input.GetKeyDown(KeyCode.A)&& Input.GetKeyDown(KeyCode.D))
        {
            facingRight = false;
        }
        if(facingRight) { transform.localScale = new Vector3(-1, 1, 1); }
        else { transform.localScale = new Vector3(1, 1, 1); }

    }
}
