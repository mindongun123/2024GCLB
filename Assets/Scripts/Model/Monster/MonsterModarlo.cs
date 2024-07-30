using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterModarlo : MonoBehaviour, IMonster
{ 

    [ReadOnly]
    public EnumsNameMonster _name = EnumsNameMonster.MonsterModarlo;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
    }
}
