using System;
using System.Collections;
using System.Collections.Generic;
using MJGame;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CardDT cardSelect;
    public Monster monterSelect;


    /// <summary>
    /// Ham tra ve danh sach cac monster bi tan cong theo hinh dang cua la bai
    /// </summary>
    /// <param name="card"></param>
    /// <param name="monster"></param>
    /// <returns></returns>
    public List<Monster> ListOfAttackedMonsters(CardDT card, Monster monster)
    {
        List<Monster> monsters = new List<Monster>();
        Dictionary<Vector2Int, MonsterDT> dictPosMonsterInLevel = SingletonComponent<GameController>.Instance.levelDatas[GameSaveCommon.Level].dictPosMonsterInLevel;
        foreach (var item in card.path)
        {
            if (dictPosMonsterInLevel.ContainsKey(item))
            {
                monsters.Add(new Monster(dictPosMonsterInLevel[item]));
            }
        }
        return monsters;
    }
}
