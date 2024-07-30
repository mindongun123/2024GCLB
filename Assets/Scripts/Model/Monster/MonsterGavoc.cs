using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterGavoc : MonoBehaviour, IMonster
{
    [ReadOnly]

    public EnumsNameMonster _name = EnumsNameMonster.MonsterGavoc;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
    }
}
