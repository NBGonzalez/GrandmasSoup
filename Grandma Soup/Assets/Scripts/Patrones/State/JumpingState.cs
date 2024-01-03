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
    }

    public override void UpdateState(PlayerStateManager player)
    {
        player.SwitchState(player.idleState);
    }

    public override void OnCollisionState(PlayerStateManager player)
    {

    }
}
