using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterRipper : MonoBehaviour, IMonster
{ 
    [ReadOnly]

    public EnumsNameMonster _name = EnumsNameMonster.MonsterRipper;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
        Debug.Log("Ripper");

    }
}
