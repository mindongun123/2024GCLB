using System.Collections;
using MJGame;
using Sirenix.OdinInspector;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;
public class Monster : MonoBehaviour
{
    [Header("Component")]
    public MonsterAnimation monsterAnimation;
    public MonsterDT monsterData;// Lay thong tin thu tu status cua monster nay trong level
    public MonsterUI monsterUI;
    public IMonster monsterInterface;

    [Header("Data")]
    public Vector2Int keyPosition;

    private void OnValidate()
    {
        monsterAnimation = GetComponent<MonsterAnimation>();
        monsterUI = GetComponent<MonsterUI>();
    }

    private void OnEnable()
    {
        monsterAnimation = GetComponent<MonsterAnimation>();
        monsterUI = GetComponent<MonsterUI>();
    }


    public Monster(MonsterDT monsterData)
    {
        this.monsterData = monsterData;
    }

    public void SetMonsterData(MonsterDT monsterData, Vector2Int keyPosition)
    {
        this.monsterData = monsterData;
        this.keyPosition = keyPosition;

        StartCoroutine(monsterUI.UpdateHealth(0, monsterData.GetHealthMax()));
    }

    private void OnMouseDown()
    {
        if (Enums.stateGame != EnumsStateGame.Player) return;

        SingletonComponent<HandleGamePlay>.Instance.SelectMonster(this);
    }


    #region Update Attribute Monster

    [Button]
    public void UpdateStateMonsterCurrent()
    {
        monsterUI.UpdateStateMonster(monsterData.GetState(SingletonComponent<GameManager>.Instance._turn));
    }

    [Button]
    public void UpdateHealth(int _value)
    {
        StartCoroutine(UpdateHealthIE(_value));

        IEnumerator UpdateHealthIE(int _value)
        {
            int _health = monsterData.GetHealth();
            int _to = _health + _value;

            _to = _to < monsterData.GetHealthMax() ? _to : monsterData.GetHealthMax();

            if (_health < _to)
            {
                // hieu ung cong them mau
            }
            if (_health > _to)
            {
                // hieu ung tru mau 
                monsterAnimation.AnimationSetState(new MonsterStateHit(monsterAnimation));
            }
            _to = _to > 0 ? _to : 0;

            monsterData.SetHealth(_to);
            if (_to == 0)
            {
                monsterAnimation.IsDie = true;
            }
            yield return StartCoroutine(monsterUI.UpdateHealth(_health, _to));
            if (_to == 0)
            {
                // hieu ung chet
                DestroyMonster();
            }
            yield return StartCoroutine(SingletonComponent<GameManager>.Instance.NextTurnIE());
            yield return null;
        }
    }

    #endregion

    public void DestroyMonster()
    {
        monsterAnimation.StateCurrent = new MonsterStateDie(monsterAnimation);
        monsterAnimation.StateCurrent.EnterState();
    }
}