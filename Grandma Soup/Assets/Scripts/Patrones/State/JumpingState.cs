using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : PlayerBaseState
{

    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Jumping State");
        
    }

    public override void UpdateState(PlayerStateManager player)
    {
        player.SwitchState(player.idleState);
    }

    public override void OnCollisionState(PlayerStateManager player)
    {

    }
}
