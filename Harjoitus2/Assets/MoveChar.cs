using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChar : MonoBehaviour
{
    public float speed = 1;
    public Rigidbody2D Rigidbody1;
    public Vector2 move;
 
 
    void Start()
    {
        Rigidbody1 = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if(Input.GetKey("w")){
            move = new Vector2(0,1);
        }else if(Input.GetKey("s")){
            move = new Vector2(0,-1);
        }else if(Input.GetKey("a")){
            move = new Vector2(-1 ,0);
        }else if(Input.GetKey("d")){
            move = new Vector2(1,0);
        }else {
            move = new Vector2(0,0);
        }

    }
 
 
    void FixedUpdate()
    {
        moveObj(move);
    }


        void moveObj(Vector2 direction)
    {
        Rigidbody1.velocity = direction * speed;
    }
}
