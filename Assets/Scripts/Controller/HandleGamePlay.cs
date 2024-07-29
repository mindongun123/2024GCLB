using System;
using System.Collections;
using System.Collections.Generic;
using MJGame;
using Sirenix.OdinInspector;
using UnityEngine;

public class HandleGamePlay : SingletonComponent<HandleGamePlay>
{

    [Header("Component")]
    [SerializeField] public LevelGamePlayController levelGamePlayController;

    [ShowInInspector]
    public List<Monster> lsMonster = new List<Monster>();

    [Header("Select")]
    [SerializeField] public CardNormal cardSelect;
    // [SerializeField] public Gun cardSelect;
    [SerializeField] public Monster monsterSelect;

    public void HandleCard(ICard _card)
    {
        if (_card is CardNormal cardNormal)
        {
            this.cardSelect = cardNormal;
        }
        else if (_card is ICardHelp cardHelp)
        {
            // Test
            cardHelp.PlayCardHelp();
        }
    }

    // public void SelectGun(Gun gun)
    // {
    //     this.gunSelect = gun;
    // }

    public void SelectMonster(Monster monster)
    {
        this.monsterSelect = monster;
    }
    [Button]
    public void OnClickPlayerShoot()
    {
        if (monsterSelect == null || cardSelect == null) return;
        else
        {
            PlayerShoot(monsterSelect.keyPosition);
        }
    }

    private void PlayerShoot(Vector2Int _pos)
    {
        // Debug.Log("Sung huong ve day");
        HandleGunDirection();
        lsMonster = levelGamePlayController.SearchMonster(_pos, cardSelect.cardData);

        AnimationMonsterSelect();
    }

    public void AnimationMonsterSelect()
    {
        foreach (var item in lsMonster)
        {
            item.monsterAnimation.AnimationSetState(new MonsterStateDie(item.monsterAnimation));
        }

        ResetHandle();
    }

    public void HandleGunDirection()
    {

    }
    public void ResetHandle()
    {
        this.cardSelect.DisableCard();
        this.cardSelect = null;
        this.monsterSelect = null;
        lsMonster = new List<Monster>();
    }
}
