using System;
using System.Collections;
using System.Collections.Generic;
using MJGame;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject monsterPrefab;
    public GameObject monsterArea;


    public Monster SpawnMonsterAtPosition(MonsterDT monsterData, int position)
    {
        GameObject monster = SpawnerCommon.SpawnObject(monsterPrefab, monsterArea.transform.GetChild(position).localPosition, Quaternion.identity);
        monster.GetComponent<Monster>().SetMonsterData(monsterData);
        return monster.GetComponent<Monster>();
    }
}
