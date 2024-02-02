using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator anim;
    Movement movement;
    void Start()
    {
        anim = GetComponent<Animator>();
        movement = GetComponent<Movement>();

    }

    void Update()
    {
      

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isRunning", true);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRunning", true);
            //movement.setFacingRight(true);
        }else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isRunning", true);
           
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }
}
