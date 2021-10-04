using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowState : IState
{
    private readonly FsmAgent owner;
    private IEnumerator routine;

    public FollowState(FsmAgent _owner)
    {
        owner = _owner;
    }

    public void Enter()
    {

    }

    public void Execute()
    {
        routine = FollowRoutine();
        owner.StartCoroutine(routine);
    }

    public void Exit()
    {
        owner.StopCoroutine(routine);
    }

    private IEnumerator FollowRoutine()
    {
        owner.Agent.SetDestination(owner.FollowTarget.transform.position);
        yield return new WaitForSeconds(0.1f);
        yield return FollowRoutine();
    }
}
