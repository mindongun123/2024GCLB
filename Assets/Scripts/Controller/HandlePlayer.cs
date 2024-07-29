using System;
using System.Collections;
using System.Collections.Generic;
using MJGame;
using MJGame.Extensions;
using UnityEngine;

public class HandlePlayer : SingletonComponent<HandlePlayer>
{
    [Header("Data")]
    public float _health = 100f;
    public MJGameText _healthText;

    private void OnEnable()
    {
        _healthText.TextLoading(_health.ToString());
    }

    public void UpdateHealth(CardHeal cardHeal)
    {
        _health += cardHeal._heal;
        Debug.Log("UpdateHealth: " + cardHeal._heal);
        _healthText.TextLoading(_health.ToString());
    }
}
