using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : IState
{
    private readonly FsmAgent owner;

    public MoveState(FsmAgent _owner) 
    { 
        owner = _owner;
    }

    public void Enter()
    {

    }

    public void Execute()
    {
        owner.Agent.SetDestination(owner.Destination);
    }

    public void Exit()
    {

    }
}
