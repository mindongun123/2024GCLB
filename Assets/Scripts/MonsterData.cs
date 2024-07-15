using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterData
{
    private int id;
    private List<int> state;

    public MonsterData(int id, List<int> state)
    {
        this.id = id;
        this.state = state;
    }
}
