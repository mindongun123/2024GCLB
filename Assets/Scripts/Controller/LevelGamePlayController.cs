using System.Collections;
using System.Collections.Generic;
using MJGame;
using Sirenix.OdinInspector;
using UnityEngine;

public class LevelGamePlayController : SingletonComponent<LevelGamePlayController>
{

    private void Start()
    {
        StartCoroutine(SetDataGamePlay());
    }

    [Header("Data In Level")]

    [ShowInInspector]
    public Dictionary<Vector2Int, Monster> lsPositionMonsterInLevel = new Dictionary<Vector2Int, Monster>();
    public List<CardNormal> listCardInLevel = new List<CardNormal>();
    public IEnumerator SetDataGamePlay()
    {
        yield return StartCoroutine(SetListDataMonsterInLevel());
        yield return StartCoroutine(SetListCardInLevel());
        Debug.Log("Complete Set Data Game Play In Level");
    }

    private IEnumerator SetListDataMonsterInLevel()
    {
        LevelDT levelData = SingletonComponent<DataGameController>.Instance.GetLevelData(GameSaveCommon.Level);
        Dictionary<Vector2Int, MonsterDT> ls = levelData.dictPosMonsterInLevel;
        foreach (var item in ls)
        {
            Monster monster = SingletonComponent<SpawnController>.Instance.SpawnMonsterAtPosition(item.Value, item.Key.x * 5 + item.Key.y, item.Key);
            lsPositionMonsterInLevel.Add(item.Key, monster);
        }
        yield return null;
    }

    IEnumerator SetListCardInLevel()
    {
        listCardInLevel = GameSaveCommon.Card;
        yield return null;
    }


/// <summary>
/// tim kiem cac monster bi ban theo hinh card va vi tri monster duoc chon
/// </summary>
/// <param name="keyPosition">Vi tri monster bat dau nguoi choi chon de ban</param>
/// <param name="card">lay ra danh sach cac diem co the de tim kiem cac vi tri monster</param>
/// <returns></returns>
    public List<Monster> SearchMonster(Vector2Int keyPosition, CardSO card)
    {
        List<Monster> lsMonster = new List<Monster>();
        foreach (var item in card.path)
        {
            if (lsPositionMonsterInLevel.ContainsKey(keyPosition + item))
            {
                lsMonster.Add(lsPositionMonsterInLevel[keyPosition + item]);
            }
        }
        return lsMonster;
    }
}
