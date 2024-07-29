using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterKazuhna : MonoBehaviour, IMonster
{ 
    [ReadOnly]
    public EnumsNameMonster _name = EnumsNameMonster.Kazuhna;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
    }
}
