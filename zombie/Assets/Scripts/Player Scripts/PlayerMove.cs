using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D myBody;
    private float moveForce_X = 1.5f, moveForcy_Y = 1.5f;
    // private PlayerAnimations=anim;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        //  anim = GetComponent<PlayerAnimations>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (h > 0)
        {
            myBody.velocity = new Vector2(moveForce_X, myBody.velocity.y);
        } 
        else if (h < 0)
        {
            myBody.velocity = new Vector2(-moveForce_X, myBody.velocity.y);
        }
        else
        {
            myBody.velocity = new Vector2(0f, myBody.velocity.y);
        }

        if (v > 0)
        {
            myBody.velocity = new Vector2(myBody.velocity.x, moveForcy_Y);
        }
        else if (v < 0)
        {
            myBody.velocity = new Vector2(myBody.velocity.x,-moveForcy_Y);
        }
        else
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 0f);
        }
        //animate
        /*if (myBody.velocity != 0 || myBody.velocity.y != 0)
        {
            anim.PlayerRunAnimation(true);
        }
        else if(myBody.velocity == 0 && myBody.velocity.y == 0)
        {
            anim.PlayerRunAnimation(false);
        }*/

        Vector3 tempScale = transform.localScale;

        if (h > 0)
        {
            tempScale.x = 1f;
        }
        else if (h < 0)
        {
            tempScale.x = -1f;
        }

        transform.localScale = tempScale;
    }
}
