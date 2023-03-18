using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_2 : MonoBehaviour
{
    private Rigidbody2D body;
    public bool reach2;
    public Wall script;
     public Player_1 obj;
    public Player_2 obj2;
    // Start is called before the first frame update
    void Start()
    {
         body = GetComponent<Rigidbody2D>();
         reach2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(script.reach == true && reach2 == true && obj.score >= 4 && obj2.score >= 4)
        {
             transform.localScale = new Vector3(0,0,0);
        
        }
       
        
       
       
    }

    public void OnCollisionEnter2D(Collision2D collisionW)
    {
       if(collisionW.gameObject.tag == "P1") 
        reach2 = true;
   
        if(collisionW.gameObject.tag == "Border") 
        reach2 = false;
    }

    
}
