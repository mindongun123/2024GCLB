using System;
using System.Collections;
using System.Collections.Generic;
using MJGame;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject monsterPrefab;
    public GameObject monsterArea;

    public void SpawnMonsterAtPosition(MonsterDT monsterData, int position)
    {
        GameObject monster = SpawnerCommon.SpawnObject(monsterPrefab, monsterArea.transform.GetChild(position - 1).localPosition, Quaternion.identity);
        monster.GetComponent<Monster>().SetMonsterData(monsterData);
    }
}
