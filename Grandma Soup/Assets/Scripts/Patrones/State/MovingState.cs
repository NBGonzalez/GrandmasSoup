using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovingState : PlayerBaseState
{
    Rigidbody2D rb;

    public override void EnterState(PlayerStateManager player, Animator anim)
    {
        Debug.Log("Moving State");
        rb = player.GetComponent<Rigidbody2D>();
    }

    public override void UpdateState(PlayerStateManager player, Animator anim)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isWalking", false);
            player.SwitchState(player.jumpingState);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(+2.5f, this.rb.velocity.y, 0);
            anim.SetBool("isWalking", true);
            player.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-2.5f, this.rb.velocity.y, 0);
            anim.SetBool("isWalking", true);
            player.GetComponent<SpriteRenderer>().flipX= true;
        }
        else
        {
            anim.SetBool("isWalking", false);
            player.SwitchState(player.idleState);
        }
    }
    public override void OnCollisionEnter2D(PlayerStateManager player, Collision2D collision, Animator anim)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            anim.SetBool("isJumping", false);
            //player.SwitchState(player.idleState);
        }
    }
}
