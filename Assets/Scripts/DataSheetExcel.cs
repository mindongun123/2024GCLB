using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public class DataSheetExcel : MonoBehaviour
{

    public void Start()
    {
        LoadMonsterPositionsFromCSV();
    }


    #region LOAD LEVEL MONSTER POSITIONS

    public TextAsset monsterPositionsData;
    public GameObject monsterPrefab;
    public GameObject monsterArea;

    public void LoadMonsterPositionsFromCSV()
    {
        string[] data = monsterPositionsData.ToString().Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

        int numLevel = data.Length / 10;
        for (int level = 1; level <= numLevel; level++)
        {
            int start = (level - 1) * 10;
            for (int pos = 1; pos <= 10; pos++)
            {
                string dataMonster = data[start + pos - 1];
                MonsterData monsterData = ExTractDataMonster(dataMonster);
                if (monsterData != null)
                {
                    SpawnMonsterAtPosition(monsterData, pos);
                }
                
            }
        }
    }

    public MonsterData ExTractDataMonster(string dataMonster)
    {
        print("data monster: " + dataMonster);
        if (dataMonster[0] != '0')
        {
            string[] parts = dataMonster.Split(' ');
            int id = int.Parse(parts[0]);
            List<int> state = new List<int>();
            for (int k = 1; k < parts.Length; k++)
            {
                state.Add(int.Parse(parts[k]));
            }
            MonsterData monsterData = new MonsterData(id, state);
            return monsterData;
        }
        return null;
    }

    public void SpawnMonsterAtPosition(MonsterData monsterData, int position)
    {
        Monster monster = Instantiate(monsterPrefab, monsterArea.transform.GetChild(position - 1)).gameObject.GetComponent<Monster>();
        monster.SetMonsterData(monsterData);   
     
    }
    #endregion



    #region LOAD CARD DETAILS


    #endregion


}
