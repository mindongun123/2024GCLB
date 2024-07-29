using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;


[CreateAssetMenu(fileName = "MonsterSO", menuName = "Data/MonsterSO", order = 1)]
public class MonsterSO : ScriptableObject
{
    [ReadOnly]
    public EnumsNameMonster _name;
    public int _id;
    public int _damage;
    public int _health;
}