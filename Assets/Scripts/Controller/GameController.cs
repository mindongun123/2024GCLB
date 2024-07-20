using MJGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : SingletonComponent<GameController>
{
    private int numLevel = 100;


    [Header("Data Common Game")]
    public List<LevelDT> levelDatas = new List<LevelDT>(100);
    /// <summary>
    /// List Monster, List Gun, List Card
    /// </summary>
    


    private void Start()
    {
        InitLevel();
        StartCoroutine(LoadAllLevelData());
    }
    public void InitLevel()
    {
        for (int i = 1; i <= numLevel; i++)
        {
            levelDatas.Add(new LevelDT(i));
        }
    }


    IEnumerator LoadAllLevelData()
    {
        yield return StartCoroutine(SingletonComponent<DataSheetExcel>.Instance.LoadDataFromExcel(levelDatas));
        Debug.Log(" Complete Load Data Level");
        SceneManager.LoadScene("GamePlay");
    }


    /// <summary>
    /// Get Data Level Current When Player Play  
    /// </summary>
    /// <param name="level">Id level current</param>
    /// <returns></returns>
    public LevelDT GetLevelData(int level)
    {
        return levelDatas[level];
    }

}
