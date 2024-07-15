using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    
    private MonsterData monsterData;
    public Monster(MonsterData monsterData)
    {
        this.monsterData = monsterData;
    }

    public void SetMonsterData(MonsterData monsterData)
    {
        this.monsterData = monsterData;
    }
}
