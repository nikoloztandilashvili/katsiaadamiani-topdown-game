using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    private Animator anim;
    Movement movement;
    bool isRunningUp;
    void Start()
    {
        anim = GetComponent<Animator>();
        movement = GetComponent<Movement>();

    }

    void Update()
    {


        if (Input.GetKey(KeyCode.A) && isRunningUp==false)
        {
            anim.SetBool("isRunningSide", true);
        }
        else if (Input.GetKey(KeyCode.D)&& isRunningUp == false)
        {
            anim.SetBool("isRunningSide", true);
            //movement.setFacingRight(true);
        } 
        else if (Input.GetKey(KeyCode.S) && isRunningUp == false)
        {
            anim.SetBool("isRunningSide", true);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isRunningUp", true);
            anim.SetBool("isRunningSide", false);
            isRunningUp = true;
        }
        else
        {
            anim.SetBool("isRunningSide", false);
            anim.SetBool("isRunningUp", false);
            isRunningUp = false;
        }
    }
}
