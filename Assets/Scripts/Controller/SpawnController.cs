using System;
using System.Collections;
using System.Collections.Generic;
using MJGame;
using Sirenix.OdinInspector;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] monsterPrefab;
    public GameObject monsterArea;


    public Monster SpawnMonsterAtPosition(MonsterDT monsterData, int idPosition, Vector2Int keyPosition)
    {
        GameObject monster = SpawnerCommon.SpawnObject(monsterPrefab[monsterData.id - 1], monsterArea.transform.GetChild(idPosition).localPosition, Quaternion.identity);
        monster.GetComponent<Monster>().SetMonsterData(monsterData, keyPosition);
        return monster.GetComponent<Monster>();
    }

    [Button]
    public void Contest()
    {
        GameObject monster = SpawnerCommon.SpawnObject(monsterPrefab[0], Vector2.zero, Quaternion.identity);
    }
}
