using System;
using System.Collections;
using System.Collections.Generic;
using MJGame;
using MJGame.Extensions;
using UnityEngine;

public class HandlePlayer : SingletonComponent<HandlePlayer>, ISetDataStart
{
    [Header("Data")]
    public int _health = 100;
    public MJGameText healthText;

    public int _mana = 100;
    public MJGameText manaText;


    private void OnEnable()
    {
        SetDataStart();
    }

    public void SetDataStart()
    {
        healthText.TextLoading("Health Player: " + _health.ToString());
        manaText.TextLoading("Mana Player: " + _mana.ToString());
    }
    public void UpdateHealth(CardHeal cardHeal)
    {
        _health += cardHeal._heal;
        healthText.TextLoading("Health Player: " + _health.ToString());
    }
    /// <summary>
    /// Sau nay doan nay se co doan check Card xem co mua duoc hay khong
    /// </summary>
    /// <param name="card"></param>
    public void UpdateMana(ICard card)
    {
        if (card == null) return;
        _mana -= card.Mana;
        manaText.TextLoading("Mana Player: " + _mana.ToString());
    }
}
