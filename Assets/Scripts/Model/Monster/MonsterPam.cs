using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MonsterPam : MonoBehaviour, IMonster
{
    [ReadOnly]

    public EnumsNameMonster _name = EnumsNameMonster.Pam;
    public MonsterSO monsterSO;

    public void EffectMonster()
    {
        Debug.Log("Pam");
    }
}