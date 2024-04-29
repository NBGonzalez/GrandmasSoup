using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingDamageState : PlayerBaseState
{
    Rigidbody2D rb;
    public override void EnterState(PlayerStateManager player, Animator anim)
    {
        rb = player.GetComponent<Rigidbody2D>();
        anim.SetBool("isWalking", false);
        anim.SetBool("isDamaging", true);
        Debug.Log("Getting Damage State");
        rb.AddForce(-rb.velocity*2, ForceMode2D.Impulse);
        player.StartCoroutine(player.GettingStunned(player));
    }

    public override void UpdateState(PlayerStateManager player, Animator anim)
    {

    }
}
