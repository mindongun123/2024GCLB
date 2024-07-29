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
    }

    private void OnMouseDown()
    {
        SingletonComponent<HandleGamePlay>.Instance.SelectMonster(this);
    }



    [Button]
    public void UpdateStateMonsterCurrent()
    {
        monsterUI.UpdateStateMonster(monsterData.GetState(SingletonComponent<GameManager>.Instance._turn));
    }

    [Button]
    public void UpdateHealth(int _value)
    {
        StartCoroutine(UpdateHealthIE(_value));
    }
    private IEnumerator UpdateHealthIE(int _value)
    {
        int _health = monsterData.GetHealth();
        int _to = _health + _value;

        _to = _to < monsterData.GetHealthMax() ? _to : monsterData.GetHealthMax();

        if (_health < _to)
        {
            // hieu ung cong them mau
            Debug.Log("Hieu ung cong them mau");
        }
        else if (_health > _to)
        {
            // hieu ung tru mau 
            Debug.Log("Hieu ung tru mau");
        }
        _to = _to > 0 ? _to : 0;

        monsterData.SetHealth(_to);
        yield return StartCoroutine(monsterUI.UpdateHealth(_health, _to));

        if (_to == 0)
        {
            DestroyMonster();
        }
        yield return null;
    }

    public void DestroyMonster()
    {
        monsterAnimation.AnimationSetState(new MonsterStateDie(monsterAnimation));
    }
}