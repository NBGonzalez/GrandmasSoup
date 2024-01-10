using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : PlayerBaseState
{
    Rigidbody2D rb;
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Jumping State");
        rb = player.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
        //GameObject other2 = GameObject.FindGameObjectWithTag("Suelo");
    }

    public override void UpdateState(PlayerStateManager player)
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(+2.5f, this.rb.velocity.y, 0);
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-2.5f, this.rb.velocity.y, 0);
        }
    }

    public override void OnCollisionEnter2D(PlayerStateManager player, Collision2D collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Suelo"))
        {
            player.SwitchState(player.idleState);
        }
    }
}
