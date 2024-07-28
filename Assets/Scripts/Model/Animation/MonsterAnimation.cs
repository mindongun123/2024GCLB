using System.Collections;
using System.Collections.Generic;
using MJGame;
using Sirenix.OdinInspector;
using Spine.Unity;
using UnityEngine;


/// <summary>
/// Phan loai ra cac loai Monster co cac Animation khac nhau
/// </summary>
public class MonsterAnimation : MonoBehaviour, IState, IStateAnimation
{
    private SkeletonAnimation _skeAnimation;

    public SkeletonAnimation SkeAnimation
    {
        get => _skeAnimation;
        set => _skeAnimation = value;
    }

    private MJStateAnimation stateCurrent;
    public MJStateAnimation StateCurrent
    {
        get => stateCurrent;
        set => stateCurrent = value;
    }

    private void Start()
    {
        SkeAnimation = GetComponent<SkeletonAnimation>();
        StateCurrent = new MonsterStateIdle(this);
        StateCurrent.EnterState();
    }

    private void Update()
    {
        StateCurrent.UpdateState();
    }

    public void AnimationSetState(MJStateAnimation state)
    {
        StateCurrent.ExitState();
        StateCurrent = state;
        StateCurrent.EnterState();
    }
}