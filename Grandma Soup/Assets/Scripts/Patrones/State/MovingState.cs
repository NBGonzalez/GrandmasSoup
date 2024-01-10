using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovingState : PlayerBaseState
{
    Rigidbody2D rb;

    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Moving State");
        rb = player.GetComponent<Rigidbody2D>();
    }

    public override void UpdateState(PlayerStateManager player)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.SwitchState(player.jumpingState);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(+2.5f, this.rb.velocity.y, 0);
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-2.5f, this.rb.velocity.y, 0);
        }
        else
        {
            player.SwitchState(player.idleState);
        }
    }
    public override void OnCollisionEnter2D(PlayerStateManager player, Collision2D collision)
    {

    }
}
