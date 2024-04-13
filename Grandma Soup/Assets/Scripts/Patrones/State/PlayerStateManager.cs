using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    PlayerBaseState currentState;
    public JumpingState jumpingState = new JumpingState();
    public MovingState movingState = new MovingState();
    public IdleState idleState = new IdleState();
    public GettingDamageState gettingDamageState = new GettingDamageState();

    public bool gettingDamage = false;

    Animator anim;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        currentState = idleState;
        currentState.EnterState(this);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        currentState.OnCollisionEnter2D(this, collision, anim);
    }

    // Update is called once per frame
    void Update()
    {
        if (gettingDamage) 
        {
            gettingDamage = false;
            currentState = gettingDamageState;
            currentState.EnterState(this);
        } 
        else 
        { 
            currentState.UpdateState(this, anim); 
        }
    }

    public void SwitchState(PlayerBaseState newState)
    {
        currentState = newState;
        newState.EnterState(this);
    }
}
