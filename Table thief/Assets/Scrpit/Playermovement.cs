using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed = 0.2f;


    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;
   
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();

    }

// Update is called once per frame
void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mySpriteRenderer.flipX = false;
            myAnimator.SetInteger("Status", 1);
            //transform.position -= new Vector3(moveSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            mySpriteRenderer.flipX = true;
            myAnimator.SetInteger("Status", 1);
           // transform.position += new Vector3(moveSpeed, 0);
        }
        else
        {
            myAnimator.SetInteger("Status", 0);
        }
    }
}

