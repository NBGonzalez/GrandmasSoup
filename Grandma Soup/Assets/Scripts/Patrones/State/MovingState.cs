using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Moving State");
    }

    public override void UpdateState(PlayerStateManager player)
    {
        
    }

    public override void OnCollisionState(PlayerStateManager player)
    {

    }
}
