using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState
{
    public abstract void EnterState(PlayerStateManager player, Animator anim);

    public abstract void UpdateState(PlayerStateManager player, Animator anim);

    public void OnCollisionEnter2D(PlayerStateManager player, Collision2D collision, Animator anim)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            anim.SetBool("isJumping", false);
        }
    }

}
