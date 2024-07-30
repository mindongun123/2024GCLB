using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterKappo : MonoBehaviour, IMonster
{
    [ReadOnly]

    public EnumsNameMonster _name = EnumsNameMonster.MonsterKappo;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
        Debug.Log("Kappo");

    }
}
