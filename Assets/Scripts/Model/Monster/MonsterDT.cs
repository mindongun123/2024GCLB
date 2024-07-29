using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[Serializable]
public class MonsterDT
{
    public int id;
    public List<int> state = new List<int>();
    public int _health = 100;
    public int _healthMax = 100;

    public MonsterDT(int id, List<int> state)
    {
        this.id = id;
        this.state = state;
    }

    public int GetState(int _turn)
    {
        return state[_turn%state.Count];
    }

    public int GetHealth()
    {
        return _health;
    }

    public void SetHealth(int _health)
    {
        this._health = _health;
    }

    public int GetHealthMax()
    {
        return _healthMax;
    }
}
