using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    private MonsterDT levelMonsterData;
    public Monster(MonsterDT monsterData)
    {
        this.levelMonsterData = monsterData;
    }

    public void SetMonsterData(MonsterDT monsterData)
    {
        this.levelMonsterData = monsterData;
    }
}
