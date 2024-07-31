using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GunNerf : MonoBehaviour, IGun, IEffectGun
{
    [Header("Data")]
    [ReadOnly]
    public EnumsNameGun nameGun = EnumsNameGun.GunNerf;

    [ReadOnly]
    public int _damage = 3;

    [ReadOnly]
    public Sprite _sprite;

    public void HandleEffect()
    {
        throw new System.NotImplementedException();
    }
}
