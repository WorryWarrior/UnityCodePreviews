using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateFactory
{
    private readonly FsmAgent agent;

    public StateFactory(FsmAgent _agent)
    {
        agent = _agent;
    }

    public IState GetState(StateType stateType)
    {
        switch (stateType)
        {
            case StateType.Move:
                return new MoveState(agent);
            case StateType.Follow:
                return new FollowState(agent);
            default:
                return null;
        }
    }
}
