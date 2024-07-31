
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
            Debug.Log("EnterState: " + this.ToString());
        }

        public virtual void ExitState()
        {
            Debug.Log("ExitState: " + this.ToString());
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