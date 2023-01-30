using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D rd;
    public Text gameover;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontally = Input.GetAxis("Horizontal");
        float vertically = Input.GetAxis("Vertical");
        rd.velocity = new Vector2(horizontally, vertically) * speed;
        
    }
  //  private void OnCollisionEnter2D(Collision2D collision)
    //{
      //  if (collision.gameObject.CompareTag("FORK"))
        //{
          //  gameover.text = "Game over!";
            //Time.timeScale = 0;
        //}
    //}
}
