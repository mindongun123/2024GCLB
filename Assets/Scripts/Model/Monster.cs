using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Drawers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Monster : MonoBehaviour
{

   [SerializeField] MonsterAnimation monsterAnimation;
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