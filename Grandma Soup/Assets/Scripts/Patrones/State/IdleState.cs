using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IdleState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Idle State");
    }

    public override void UpdateState(PlayerStateManager player, Animator anim)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
            anim.SetBool("isJumping", false);
            player.SwitchState(player.jumpingState);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            player.SwitchState(player.movingState);
        }
    }

    public override void OnCollisionEnter2D(PlayerStateManager player, Collision2D collision, Animator anim)
    {

    }
}
