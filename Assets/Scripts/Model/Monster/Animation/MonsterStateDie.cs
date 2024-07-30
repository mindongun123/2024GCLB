using System.Collections;
using System.Collections.Generic;
using MJGame;
using Spine.Unity;
using UnityEditor.Hardware;
using UnityEngine;

public class MonsterStateDie : MJStateAnimation
{
    public MonsterStateDie(MonsterAnimation kstate) : base(kstate)
    {
    }

    public override void EnterState( )
    {
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
        Debug.Log("DESTROY MONSTER");  
        GameObject.Destroy(kstate.gameObject);
    }
    public override void UpdateState()
    {
    }
}