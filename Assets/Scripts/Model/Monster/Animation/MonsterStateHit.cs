using System.Collections;
using System.Collections.Generic;
using MJGame;
using UnityEngine;

public class MonsterStateHit : MJStateAnimation
{

    public MonsterStateHit(MonsterAnimation kstate) : base(kstate)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
        kstate.SkeAnimation.AnimationName = "hit";
        kstate.SkeAnimation.loop = false;
        kstate.SkeAnimation.Initialize(true);
        kstate.StartCoroutine(Delay());
        IEnumerator Delay()
        {
            yield return new WaitForSeconds(1);
            if (!kstate.IsDie)
            {
                kstate.StateCurrent.ExitState();
            }
        }
    }
    public override void ExitState()
    {
        base.ExitState();
        if (!kstate.IsDie)
        {
            kstate.StateCurrent = new MonsterStateIdle(kstate);
            kstate.StateCurrent.EnterState();
        }
    }
    public override void UpdateState()
    {
    }
}

