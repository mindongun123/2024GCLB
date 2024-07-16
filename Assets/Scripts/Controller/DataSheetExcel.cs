using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MJGame;
using UnityEngine;

public class DataSheetExcel : SingletonComponent<DataSheetExcel>
{

    #region LOAD LEVEL MONSTER POSITIONS

    [Header("Load Data Monster In Level")]
    public TextAsset monsterPositionsData;
    private void LoadLevelMonsterPositionsFromCSV(List<LevelData> levelDatas)
    {
        string[] data = monsterPositionsData.ToString().Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

        int numLevel = data.Length / 10;
        for (int level = 1; level <= numLevel; level++)
        {
            int start = (level - 1) * 10;
            List<MonsterDT> monsterDatas = new List<MonsterDT>();
            for (int pos = 1; pos <= 10; pos++)
            {
                string dataMonster = data[start + pos - 1];
                MonsterDT monsterData = ExTractDataMonster(dataMonster);
                monsterDatas.Add(monsterData);
                /*if (monsterData != null)
                {
                    //SpawnMonsterAtPosition(monsterData, pos);
                }*/

            }
            if (monsterDatas.Count > 0)
            {
                levelDatas[level - 1].SetMonsterData(monsterDatas);
            }
        }
    }

    private MonsterDT ExTractDataMonster(string dataMonster)
    {
        if (dataMonster[0] != '0')
        {
            string[] parts = dataMonster.Split(' ');
            int id = int.Parse(parts[0]);
            List<int> state = new List<int>();
            for (int k = 1; k < parts.Length; k++)
            {
                state.Add(int.Parse(parts[k]));
            }
            MonsterDT monsterData = new MonsterDT(id, state);
            return monsterData;
        }
        return null;
    }

  
    #endregion

    #region LOAD LEVEL GUN

    [Header("Load Data Gun")]
    public TextAsset levelGunData;

    private void LoadLevelGunFromCSV(List<LevelData> levelDatas)
    {
        string[] data = levelGunData.ToString().Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
        data = data.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
        int numLevel = data.Length;

        for (int i = 1; i <= numLevel; i++)
        {
            string dataGun = data[i - 1];
            List<int> listGun = new List<int>();
            string[] parts = dataGun.Split(' ');
            parts = parts.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
            for (int k = 0; k < parts.Length; k++)
            {
                listGun.Add(int.Parse(parts[k]));
            }
            levelDatas[i - 1].SetGunData(listGun);
        }
    }

    #endregion

    #region LOAD LEVEL CARD REWARD
    [Header("Load Data Card Reward")]
    public TextAsset levelCardRewardData;

    private void LoadLevelCardRewardFromCSV(List<LevelData> levelDatas)
    {
        string[] data = levelCardRewardData.ToString().Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
        data = data.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
        int numLevel = data.Length;

        for (int i = 1; i <= numLevel; i++)
        {
            string dataCard = data[i - 1];

            List<int> listCardData = new List<int>();
            string[] parts = dataCard.Split(' ');
            parts = parts.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
            for (int k = 0; k < parts.Length; k++)
            {
                listCardData.Add(int.Parse(parts[k]));
            }
            levelDatas[i - 1].SetCardRewardData(listCardData);
        }
    }
    #endregion

    #region LOAD  DATA MONSTER
    #endregion

    #region LOAD DATA GUN
    #endregion

    #region LOAD DATA CARD 
    #endregion

    public void LoadDataFromExcel(List<LevelData> levelDatas)
    {
        LoadLevelMonsterPositionsFromCSV(levelDatas);
        LoadLevelCardRewardFromCSV(levelDatas);
        LoadLevelGunFromCSV(levelDatas);
    }

}
