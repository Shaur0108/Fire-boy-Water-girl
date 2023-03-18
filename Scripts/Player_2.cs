using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{
    private Rigidbody2D body;
    private float jump;
    private bool Grounded;
     private float HorizontalInput_2;
    private float speed;
     private Animator run;
     public bool lvl;
     public float score;
     public float death_2;

     public Player_1 script;

     public bool alive;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        run = GetComponent<Animator>();
        score = 0;
    }

    void Start()
    {
        alive = true;
        jump = 9f;
        Grounded = true;
        speed = 3f;
        death_2 = 0;
    }

    // Update is called once per frame
    void Update()
    { 
         if(death_2 == 3)
         alive = false;
         
         float HorizontalInput_2 = Input.GetAxis("Horizontal");
         if(HorizontalInput_2 == 0.0f)
         run.SetBool("Run_2", false);
       
       if(Input.GetKey(KeyCode.RightArrow))
       {
        body.velocity = new Vector2(HorizontalInput_2 * speed, body.velocity.y); 
        transform.localScale = new Vector3(2,2);
        run.SetBool("Run_2", true);
       }
      

       if(Input.GetKey(KeyCode.LeftArrow))
       {
        body.velocity = new Vector2(HorizontalInput_2-3, body.velocity.y); 
         transform.localScale = new Vector2(-2,2);
          run.SetBool("Run_2", true);
       }
     
       

            if(Input.GetKey(KeyCode.UpArrow))
        Jump_1();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Gravity
     if (collision.gameObject.tag == "Untagged")
           Grounded = true;

    if (collision.gameObject.tag == "Lvl1")
    {
        body.position = new Vector2(0.2f,13f);
        lvl = true;
    }

    if(collision.gameObject.tag == "Enemy")
       {
          death_2 = death_2 + 1;
       }
       if(collision.gameObject.tag == "Obj")
        score = score+1;
        
    }

     void Jump_1()
    {
     if(Grounded == true)
         body.velocity = new Vector2(body.velocity.x, jump);
        Grounded = false;
    }
}
 