using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMonsterData
{
    private int id;
    private List<int> state;

    public LevelMonsterData(int id, List<int> state)
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
