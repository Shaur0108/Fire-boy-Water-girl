using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private Rigidbody2D body;
    public bool reach;
    public wall_2 script;
    public Player_1 obj;
    public Player_2 obj2;
    // Start is called before the first frame update


    void Start()
    {
         body = GetComponent<Rigidbody2D>();
         reach = false;
    }

    // Update is called once per frame
    void Update()
    {
         if(reach == true && script.reach2 == true && obj.score >= 4 && obj2.score >= 4)
        transform.localScale = new Vector3(0,0,0);

        
    }

    private void OnCollisionEnter2D(Collision2D collisionG)
    {
       if(collisionG.gameObject.tag == "P2") 
        reach = true;

        if(collisionG.gameObject.tag == "Border") 
        reach = false;
    }

    
}
