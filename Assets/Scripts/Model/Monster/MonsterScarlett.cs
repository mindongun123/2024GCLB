using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterScarlett : MonoBehaviour, IMonster
{ 
    [ReadOnly]
    public EnumsNameMonster _name = EnumsNameMonster.MonsterScarlett;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
    }
}
