using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IdleState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player, Animator anim)
    {
        Debug.Log("Idle State");
    }

    public override void UpdateState(PlayerStateManager player, Animator anim)
    {
        //anim.SetBool("isWalking", false);
        if (Input.GetKeyDown(KeyCode.Space) && !anim.GetBool("isJumping"))
        {
            player.SwitchState(player.jumpingState);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            player.SwitchState(player.movingState);
        }
    }
}
