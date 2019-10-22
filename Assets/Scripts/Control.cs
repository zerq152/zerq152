using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : Character
{

    public Animator animator;

    public Rigidbody2D rb;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    protected override void Update()
    {
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        GetInput();

        base.Update();
    }



    private void GetInput()
    {
        Movement = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            Movement += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Movement += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Movement += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement += Vector2.right;
        }
    }

}