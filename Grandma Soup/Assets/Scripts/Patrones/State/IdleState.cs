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

    public override void UpdateState(PlayerStateManager player)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.SwitchState(player.jumpingState);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            player.SwitchState(player.movingState);
        }
    }

    public override void OnCollisionState(PlayerStateManager player)
    {

    }
}
