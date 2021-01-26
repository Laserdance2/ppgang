using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJumping : MonoBehaviour
{
    private Rigidbody2D rb;
    private Movement move;
    [HideInInspector]
    public bool inWater;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float waterMulitplier = 2.5f;
    public float waterJumpMulitplier = 2f;
    public float waterMoveSpeed = 2f;
    private float waterBreak = 0.75f;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        move = GetComponent<Movement>();
    }

    public void Update()
    {
        if(rb.velocity.y < 0 && inWater == false)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }else if(rb.velocity.y > 0 && !Input.GetButton("Jump") && inWater == false)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

        if (rb.velocity.y < 0 && inWater == true)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (waterMulitplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && inWater == true)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (waterJumpMulitplier - 1) * Time.deltaTime;
        }




    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Water")
        {
            inWater = true;
            rb.velocity -= rb.velocity * waterBreak;
            move.speed = move.speed / waterMoveSpeed;
        } 
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Water")
        {
            inWater = false;
            move.speed = move.speed * waterMoveSpeed;
        }
    }

}
