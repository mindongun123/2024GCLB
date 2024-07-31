using System.Collections;
using System.Collections.Generic;
using MJGame;
using UnityEngine;

public class MonsterStateIdle : MJStateAnimation
{
    public MonsterStateIdle(MonsterAnimation kstate) : base(kstate)
    {
    }

    public override void EnterState()
    {
       base.EnterState();
        kstate.SkeAnimation.AnimationName = "idle";
        kstate.SkeAnimation.loop = true;
        kstate.SkeAnimation.Initialize(true);
    }
    public override void ExitState()
    {
    }
    public override void UpdateState()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     kstate.StateCurrent = new MonsterStateAttack(kstate);
        //     kstate.StateCurrent.EnterState(1);
        // }
        // else if (Input.GetMouseButtonDown(1))
        // {
        //     kstate.StateCurrent = new MonsterStateHit(kstate);
        //     kstate.StateCurrent.EnterState(1);
        // }
        // else if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     kstate.StateCurrent = new MonsterStateDie(kstate);
        //     kstate.StateCurrent.EnterState(1);
        // }
    }
}
