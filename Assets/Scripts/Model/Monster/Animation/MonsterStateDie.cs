using System.Collections;
using MJGame;
using UnityEngine;

public class MonsterStateDie : MJStateAnimation
{
    public MonsterStateDie(MonsterAnimation kstate) : base(kstate)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
        kstate.SkeAnimation.AnimationName = "die";
        kstate.SkeAnimation.loop = false;
        kstate.SkeAnimation.Initialize(true);
        kstate.StartCoroutine(Delay());
        IEnumerator Delay()
        {
            yield return new WaitForSeconds(1);
            kstate.StateCurrent.ExitState();
        }
    }
    public override void ExitState()
    {
        base.ExitState();
        Debug.Log("DESTROY MONSTER");
        GameObject.Destroy(kstate.gameObject);
    }
    public override void UpdateState()
    {
    }
}
