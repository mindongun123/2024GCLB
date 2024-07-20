using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class MonsterDT
{
    public int id;
    public List<int> state = new List<int>();

    public MonsterDT(int id, List<int> state)
    {
        this.id = id;
        this.state = state;
    }
    public override string ToString()
    {
        string states = "";
        foreach (var i in state)
        {
            states += i.ToString() + " ";
        }
        return "Monster id: " + id + ". List states: " + states;
    }
}
