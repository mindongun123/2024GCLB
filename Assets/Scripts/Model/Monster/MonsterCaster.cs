using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterCaster : MonoBehaviour, IMonster
{ 
    [ReadOnly]

    public EnumsNameMonster _name = EnumsNameMonster.MonsterCaster;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
    }
}
