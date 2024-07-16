using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    
    private LevelMonsterData levelMonsterData;
    public Monster(LevelMonsterData monsterData)
    {
        this.levelMonsterData = monsterData;
    }

    public void SetMonsterData(LevelMonsterData monsterData)
    {
        this.levelMonsterData = monsterData;
    }
}
