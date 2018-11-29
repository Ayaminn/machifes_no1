using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour {

    private Animator animator;
    public float yrote = 0.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            animator.SetBool("jump", true);
            animator.SetBool("walk_f", false);
            animator.SetBool("walk_b", false);

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            //回転している方向にすすむようにちょっとややこしくしたよ
            transform.position += transform.TransformDirection(Vector3.forward) * 0.1f;
            animator.SetBool("walk_f", true);
            animator.SetBool("jump", false);
            animator.SetBool("walk_b", false);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.position += transform.TransformDirection(Vector3.forward) * -0.05f;
            animator.SetBool("walk_b", true);
            animator.SetBool("walk_f", false);
            animator.SetBool("jump", false);

        }
        else
        {

            animator.SetBool("jump", false);
            animator.SetBool("walk_f", false);
            animator.SetBool("walk_b", false);

        }


        if (Input.GetKey(KeyCode.RightArrow))
        {

            yrote = transform.eulerAngles.y + 1;
            transform.rotation = Quaternion.Euler(0, yrote, 0);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            yrote = transform.eulerAngles.y - 1;
            transform.rotation = Quaternion.Euler(0, yrote, 0);
        }

    }
}
