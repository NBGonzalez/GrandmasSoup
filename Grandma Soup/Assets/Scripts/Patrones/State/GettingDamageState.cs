using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingDamageState : PlayerBaseState
{
    Rigidbody2D rb;
    public override void EnterState(PlayerStateManager player)
    {
        rb = player.GetComponent<Rigidbody2D>();
        Debug.Log("Getting Damage State");
        rb.AddForce(-rb.velocity*2, ForceMode2D.Impulse);
        //StartCoroutine(Stun(player));
        Stun(player).MoveNext();
        
    }

    public override void UpdateState(PlayerStateManager player, Animator anim)
    {
        //rb.AddForce(new Vector2(0,4), ForceMode2D.Impulse);
        //rb.AddForce(-rb.velocity*4, ForceMode2D.Impulse);
        
        Debug.Log("Estoy en GettingDamage");
    }

    public override void OnCollisionEnter2D(PlayerStateManager player, Collision2D collision, Animator anim)
    {
        
    }
    public IEnumerator Stun(PlayerStateManager player)
    {
        Debug.Log("Acabo de ser estuneado");
        yield return new WaitForSeconds(1);
        Debug.Log("Ya no estoy estuneado");
        player.gettingDamage = false;
        player.SwitchState(player.idleState);
    }
}
