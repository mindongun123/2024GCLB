using System;
using System.Collections;
using System.Collections.Generic;
using MJGame;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] monsterPrefab;
    public GameObject monsterArea;


    public Monster SpawnMonsterAtPosition(MonsterDT monsterData, int idPosition, Vector2Int keyPosition)
    {
        GameObject monster = SpawnerCommon.SpawnObject(monsterPrefab[monsterData.id-1], monsterArea.transform.GetChild(idPosition).localPosition, Quaternion.identity);
        monster.GetComponent<Monster>().SetMonsterData(monsterData, keyPosition);
        return monster.GetComponent<Monster>();
    }
}
