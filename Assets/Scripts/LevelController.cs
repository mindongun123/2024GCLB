using MJGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private int currentLevel;
    private int numLevel = 100;
    public List<LevelData> levelDatas = new List<LevelData>(100);

    public void Start()
    {
        InitLevel();
        LoadAllLevelData();
        print(GetLevelData(2).ToString());
        
    }
    public void InitLevel()
    {
        for (int i = 1; i <= numLevel; i++)
        {
            levelDatas.Add(new LevelData());
        }  
    }
    public void LoadAllLevelData()
    {
        DataSheetExcel.instance.LoadLevelMonsterPositionsFromCSV(levelDatas);
        DataSheetExcel.instance.LoadLevelCardRewardFromCSV(levelDatas);
        DataSheetExcel.instance.LoadLevelGunFromCSV(levelDatas);
    }

    public LevelData GetLevelData(int level)
    {
        return levelDatas[level - 1];
    }
}


public class LevelData
{
    public List<LevelMonsterData> monsterDatas = null;
    public List<int> cardRewardData = null;
    public List<int> gunData = null;

    public void SetMonsterData(List<LevelMonsterData> monsterDatas)
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
        foreach(var i in monsterDatas)
        {
            if (i == null) monster += " Null ";
            else monster += i.ToString() + " ";
;        }
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