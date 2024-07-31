using System;
using System.Collections;
using System.Collections.Generic;
using MJGame;
using UnityEngine;

public class HandleEffectGun : SingletonComponent<HandleEffectGun>
{

    public List<MonsterEffectBurn> listBurnEffect = new List<MonsterEffectBurn>();

    public List<Monster> listStunnedEffect = new List<Monster>();

    public Dictionary<Monster, int> dictAccumulateDamageEffect = new Dictionary<Monster, int>();

    public void HandleEffectBurn(List<Monster> lsMonster, int _damage)
    {
        listBurnEffect.Add(new MonsterEffectBurn(lsMonster, _damage));
    }

    public void HandleEffectSkipArmor()
    {

    }

    public void HandleEffectStunned(List<Monster> lsMonster)
    {
        listStunnedEffect = lsMonster;
        foreach (var item in lsMonster)
        {
            Debug.Log("Choang den cuoi turn khong lam gi duoc");
        }
    }

    public void HandleEffectSDisabledSelect()
    {

    }

    public void HandleEffectReduceDamage()
    {

    }
    public void HandleEffectAccumulateDamage(Monster monster, int _damage)
    {
        if (dictAccumulateDamageEffect.ContainsKey(monster))
        {
            dictAccumulateDamageEffect[monster] += 1;
        }
        else
        {
            dictAccumulateDamageEffect.Add(monster, 1);
        }
        monster.UpdateHealth(-_damage * dictAccumulateDamageEffect[monster]);
    }
}

[Serializable]
public class MonsterEffectBurn
{
    public List<Monster> lsMonster;
    public int _damage;

    public MonsterEffectBurn(List<Monster> monster, int _damage)
    {
        this.lsMonster = monster;
        this._damage = _damage;
    }
}
