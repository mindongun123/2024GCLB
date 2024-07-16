using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
>>>>>>> MPbranch
using UnityEngine;

public class DataSheetExcel : MonoBehaviour
{
    public static DataSheetExcel instance { get; private set; }
    public void Awake()
    {
        instance = this;
    }

    #region LOAD LEVEL MONSTER POSITIONS

    public TextAsset monsterPositionsData;
    public GameObject monsterPrefab;
    public GameObject monsterArea;

    public void LoadLevelMonsterPositionsFromCSV(List<LevelData> levelDatas)
    {
        string[] data = monsterPositionsData.ToString().Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

        int numLevel = data.Length / 10;
        for (int level = 1; level <= numLevel; level++)
        {
            int start = (level - 1) * 10;
            List<LevelMonsterData> monsterDatas = new List<LevelMonsterData>();
            for (int pos = 1; pos <= 10; pos++)
            {
                string dataMonster = data[start + pos - 1];
                LevelMonsterData monsterData = ExTractDataMonster(dataMonster);
                monsterDatas.Add(monsterData);
                /*if (monsterData != null)
                {
                    //SpawnMonsterAtPosition(monsterData, pos);
                }*/
                
            }
            if (monsterDatas.Count > 0)levelDatas[level - 1].SetMonsterData(monsterDatas);
        }
    }

    public LevelMonsterData ExTractDataMonster(string dataMonster)
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
            LevelMonsterData monsterData = new LevelMonsterData(id, state);
            return monsterData;
        }
        return null;
    }

    public void SpawnMonsterAtPosition(LevelMonsterData monsterData, int position)
    {
        Monster monster = Instantiate(monsterPrefab, monsterArea.transform.GetChild(position - 1)).gameObject.GetComponent<Monster>();
        monster.SetMonsterData(monsterData);   
     
    }
    #endregion

    #region LOAD GUN REWARD
    public TextAsset levelGunData;

    public void LoadLevelGunFromCSV(List<LevelData> levelDatas)
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
    public TextAsset levelCardRewardData;

    public void LoadLevelCardRewardFromCSV(List<LevelData> levelDatas)
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



}
