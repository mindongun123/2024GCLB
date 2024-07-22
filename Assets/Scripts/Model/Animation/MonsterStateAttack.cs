using System.Collections;
using System.Collections.Generic;
using MJGame;
using UnityEngine;

public class MonsterStateAttack : MJStateAnimation
{
    public MonsterStateAttack(MonsterAnimation kstate) : base(kstate)
    {
    }

    public override void EnterState()
    {
        kstate.SkeAnimation.AnimationName = "attack";
        kstate.SkeAnimation.loop = false;
        kstate.SkeAnimation.Initialize(true);

        kstate.StartCoroutine(Delay());
        IEnumerator Delay()
        {
            yield return new WaitForSeconds(1.0f);
            kstate.StateCurrent.ExitState();
        }
    }
    public override void ExitState()
    {
        kstate.StateCurrent = new MonsterStateIdle(kstate);
        kstate.StateCurrent.EnterState();
    }
    public override void UpdateState()
    {
    }
}
