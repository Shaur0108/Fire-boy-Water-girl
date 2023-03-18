using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public Rigidbody2D Body;
    private float speed;
    [SerializeField] private float jump;
    private bool Grounded;
    private Animator run;
    private float HorizontalInput;
    public bool lvl;
    public float score;
    public float death;

    public bool Alive;
    

    void Awake()
    {
        Body = GetComponent<Rigidbody2D>();
        run = GetComponent<Animator>();
       
        
    }
    void Start()
    {
        speed = 3f;
        jump = 9f;
        Grounded = true;
         score = 0;
         death = 0;
         Alive = true;
       
        
    }

    
    void Update()
    {
        if(death == 3)
         Alive = false;
    
       //Left and right movement
        float HorizontalInput = Input.GetAxis("Horizontal"); 
    

     if(HorizontalInput == 0.0f)
         run.SetBool("Run", false);
         
        
       
       if(Input.GetKey(KeyCode.D))
       {
         transform.localScale = new Vector3(2,2);
         Body.velocity = new Vector2(HorizontalInput*speed, Body.velocity.y); 
         run.SetBool("Run", true);

       }
       
       

       if(Input.GetKey(KeyCode.A))
       {
        transform.localScale = new Vector2(-2,2);
         Body.velocity = new Vector2(HorizontalInput-3, Body.velocity.y);
         run.SetBool("Run", true);
       }
       
       
        //Jumping
        if(Input.GetKey(KeyCode.W))
        Jump();
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Gravity
     if (collision.gameObject.tag == "Untagged")
           Grounded = true;

    if (collision.gameObject.tag == "Lvl1")
       {
        Body.position = new Vector2(0.2f,13f);
        lvl = true;
       } 

       if(collision.gameObject.tag == "Enemy")
       { 
        death = death + 1;
       }
        if(collision.gameObject.tag == "Obj")
        score = score+1;
    }

    private void Jump()
    {
        //Jump
         if(Grounded == true)
         Body.velocity = new Vector2(Body.velocity.x, jump);
        Grounded = false;
    }
        


    
}
