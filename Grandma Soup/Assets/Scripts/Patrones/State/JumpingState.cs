using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : PlayerBaseState
{
    Rigidbody2D rb;
    public override void EnterState(PlayerStateManager player, Animator anim)
    {
        Debug.Log("Jumping State");
        rb = player.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
        anim.SetBool("isJumping", true);
    }

    public override void UpdateState(PlayerStateManager player, Animator anim)
    {
        

        if(Input.GetKey("d") || Input.GetKey("a"))
        {
            player.SwitchState(player.idleState);
        }

    }
}
