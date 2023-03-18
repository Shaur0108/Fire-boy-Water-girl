using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    private Rigidbody2D body;
    public Player_1 script;
    public Player_2 script2;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        body.position = new Vector2(0,-0.68f);
       
        if(Input.GetKey(KeyCode.Alpha2))
        body.position = new Vector2(0.2f,16f);

        if(Input.GetKey(KeyCode.Alpha3))
        body.position =  new Vector2(0f,-7.5f);
       
       
        if(script.lvl == true && script2.lvl == true)
        body.position = new Vector2(0.2f,16f);

        if(script.Alive == false)
        body.position = new Vector2(0f,-10.5f);

         if(script2.alive == false)
        body.position = new Vector2(0f,-10.5f);

       


    }
}
