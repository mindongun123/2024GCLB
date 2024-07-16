using MJGame;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : SingletonComponent<LevelController>
{

    [Header("Data Level Play")]
    private int numLevel = 100;
    public List<LevelData> levelDatas = new List<LevelData>(100);

    [Header("Data Common Game")]
    /// <summary>
    /// List Monster, List Gun, List Card
    /// </summary>
    public List<int> listCardPlayer = new List<int>();


    public void Start()
    {
        InitLevel();
        LoadAllLevelData();
    }
    public void InitLevel()
    {
        for (int i = 1; i <= numLevel; i++)
        {
            levelDatas.Add(new LevelData(i));
        }
    }
    public void LoadAllLevelData()
    {
        SingletonComponent<DataSheetExcel>.Instance.LoadDataFromExcel(levelDatas);
    }


    /// <summary>
    /// Get Data Level Current When Player Play  
    /// </summary>
    /// <param name="level">Id level current</param>
    /// <returns></returns>
    public LevelData GetLevelData(int level)
    {
        return levelDatas[level - 1];
    }


    
}


[Serializable]
public class LevelData
{

    [ReadOnly]
    public string nameLevel;
    public List<MonsterDT> monsterDatas = new List<MonsterDT>();
    public List<int> cardRewardData = new List<int>();
    public List<int> gunData = new List<int>();

    public LevelData(int _id)
    {
        nameLevel = "Level " + _id;
    }
    public void SetMonsterData(List<MonsterDT> monsterDatas)
    {
        this.monsterDatas = monsterDatas;
    }

    public void SetCardRewardData(List<int> cardRewardData)
    {
        this.cardRewardData = cardRewardData;
    }

    public void SetGunData(List<int> gunData)
    {
        this.gunData = gunData;
    }

    public override string ToString()
    {
        if (monsterDatas == null || cardRewardData == null || gunData == null) return "Data not done";
        string monster = "";
        foreach (var i in monsterDatas)
        {
            if (i == null) monster += " Null ";
            else monster += i.ToString() + " ";
            ;
        }
        string cardReward = "";
        foreach (var i in cardRewardData)
        {
            cardReward += i.ToString() + " ";
        }

        string gun = "";
        foreach (var i in gunData)
        {
            gun += i.ToString() + " ";
        }
        return "LEVEL DATA:\n" + monster.ToString() + "\n" + "List Card Reward: " + cardReward + "\n" + "List gun: " + gun;
    }
}