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
    public List<Card> listCardInLevel = new List<Card>();
    public IEnumerator SetDataGamePlay()
    {
        yield return StartCoroutine(SetListDataMonsterInLevel());
        yield return StartCoroutine(SetListCardInLevel());
        Debug.Log("Complete Set Data Game Play In Level");
    }

    private IEnumerator SetListDataMonsterInLevel()
    {
        LevelDT levelData = SingletonComponent<GameController>.Instance.GetLevelData(GameSaveCommon.Level);
        Dictionary<Vector2Int, MonsterDT> ls = levelData.dictPosMonsterInLevel;
        foreach (var item in ls)
        {
            Monster monster = SingletonComponent<SpawnController>.Instance.SpawnMonsterAtPosition(item.Value, item.Key.x * 5 + item.Key.y);
            monster.SetIdPosition(item.Key.x, item.Key.y);
            lsPositionMonsterInLevel.Add(item.Key, monster);
        }
        yield return null;
    }

    IEnumerator SetListCardInLevel()
    {
        listCardInLevel = GameSaveCommon.Card;
        yield return null;
    }

}
