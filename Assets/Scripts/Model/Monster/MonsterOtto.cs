using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterOtto : MonoBehaviour, IMonster
{ 
    [ReadOnly]

    public EnumsNameMonster _name = EnumsNameMonster.Otto;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
    }
}
