using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterMagaritta : MonoBehaviour, IMonster
{ 
    [ReadOnly]
    public EnumsNameMonster _name = EnumsNameMonster.MonsterMagaritta;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
    }
}
