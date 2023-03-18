using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_P1 : MonoBehaviour
{
    public Player_1 script;
    public Rigidbody2D body;
    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        transform.localScale = new Vector2(2.17f, 0.445f);
    }

    // Update is called once per frame
    void Update()
    {
        if(script.death == 1)
        {
           transform.localScale = new Vector2(4f, 0.445f);
            
        }

        if(script.death == 2)
        {
           transform.localScale = new Vector2(6f, 0.445f);
            
        }

        if(script.death == 3)
        {
           transform.localScale = new Vector2(8f, 0.445f);
            
        }

        if(script.death == 4)
        {
           transform.localScale = new Vector2(10f, 0.445f);
            
        }

        if(script.death == 5)
        {
           transform.localScale = new Vector2(12f, 0.445f);
            
        }
    }
}
