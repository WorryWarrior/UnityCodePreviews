using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class FsmAgent : MonoBehaviour
{
    private readonly StateMachine fsm = new StateMachine();
    private StateFactory stateFactory;
   
    public NavMeshAgent Agent { get; private set; }
    public Vector3 Destination { get; private set; }
    public Transform FollowTarget { get; private set; }

    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();
        stateFactory = new StateFactory(this);
    }

    public void Move(Vector3 destination)
    {
        Destination = destination;
        fsm.ChangeState(stateFactory.GetState(StateType.Move));
        fsm.Update();
    }

    public void Follow(Transform followTarget)
    {
        FollowTarget = followTarget;
        fsm.ChangeState(stateFactory.GetState(StateType.Follow));
        fsm.Update();
    }
}
