using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[Serializable]
public class LevelDT
{

    [ReadOnly]
    public string nameLevel;

    /// <summary>
    /// luu tru vi tri cua monster trong level
    /// </summary>
    /// <typeparam name="Vector2Int"></typeparam>
    /// <typeparam name="MonsterDT"></typeparam>
    /// <returns></returns>

    [ShowInInspector]
    public Dictionary<Vector2Int, MonsterDT> dictPosMonsterInLevel = new Dictionary<Vector2Int, MonsterDT>();
    public List<int> lsCardRewardData = new List<int>();
    public List<int> lsGunData = new List<int>();

    public LevelDT(int _id)
    {
        nameLevel = "Level " + _id;
    }
    public void SetMonsterData(Dictionary<Vector2Int, MonsterDT> monsterDatas)
    {
        this.dictPosMonsterInLevel = monsterDatas;
    }

    public void SetCardRewardData(List<int> cardRewardData)
    {
        this.lsCardRewardData = cardRewardData;
    }

    public void SetGunData(List<int> gunData)
    {
        this.lsGunData = gunData;
    }

    public override string ToString()
    {
        if (dictPosMonsterInLevel == null || lsCardRewardData == null || lsGunData == null) return "Data not done";
        string monster = "";
        foreach (var i in dictPosMonsterInLevel)
        {
            monster += i.ToString() + " ";
        }
        string cardReward = "";
        foreach (var i in lsCardRewardData)
        {
            cardReward += i.ToString() + " ";
        }

        string gun = "";
        foreach (var i in lsGunData)
        {
            gun += i.ToString() + " ";
        }
        return "LEVEL DATA:\n" + monster.ToString() + "\n" + "List Card Reward: " + cardReward + "\n" + "List gun: " + gun;
    }
}