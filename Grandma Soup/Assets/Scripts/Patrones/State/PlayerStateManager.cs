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

    private CharacterController characterController;
    private int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        characterController= GetComponent<CharacterController>();

        currentState = idleState;
        currentState.EnterState(this);
    }

    void OnCollisionEnter(Collision2D collision)
    {
        //currentState.OnCollisionEnter(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(PlayerBaseState newState)
    {
        currentState = newState;
        newState.EnterState(this);
    }
}
