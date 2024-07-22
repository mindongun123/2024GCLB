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
        kstate.SkeAnimation.AnimationName = "hit";
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

        // sau phai co ham tru mau cua monster khi bi nguoi choi ban
    }
    public override void UpdateState()
    {
    }
}

