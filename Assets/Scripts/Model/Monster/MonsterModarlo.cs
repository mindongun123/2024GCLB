using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterModarlo : MonoBehaviour, IMonster
{ 

    [ReadOnly]
    public EnumsNameMonster _name = EnumsNameMonster.Modarlo;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
    }
}