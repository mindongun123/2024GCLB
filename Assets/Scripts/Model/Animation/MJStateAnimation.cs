using System.Collections;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;

namespace MJGame
{

    public abstract class MJStateAnimation
    {
        public MonsterAnimation kstate;
        public MJStateAnimation(MonsterAnimation kstate)
        {
            this.kstate = kstate;
        }

        public virtual void EnterState()
        {
        }

        public virtual void ExitState()
        {
        }

        public abstract void UpdateState();
    }

    public interface IState
    {

    }
    public interface IStateAnimation : IState
    {
        public MJStateAnimation StateCurrent { get; set; }
        public SkeletonAnimation SkeAnimation { get; set; }
    }
}