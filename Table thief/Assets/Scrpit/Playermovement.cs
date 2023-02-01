using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed = 0.2f;
    Rigidbody2D rd;

    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;
   
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        rd = GetComponent<Rigidbody2D>();

    }

// Update is called once per frame
void Update()
    {
        float horizontally = Input.GetAxis("Horizontal");
        float vertically = Input.GetAxis("Vertical");
        rd.velocity = new Vector2(horizontally, vertically) * moveSpeed;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mySpriteRenderer.flipX = false;
            myAnimator.SetInteger("Status", 1);
           // transform.position -= new Vector3(moveSpeed, 0);
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

