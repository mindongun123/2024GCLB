using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GunFlameThrower : MonoBehaviour, IGun, IEffectGun
{
    [Header("Data")]
    [ReadOnly]
    public EnumsNameGun nameGun = EnumsNameGun.GunFlameThrower;
    [ReadOnly]
    public int _damage = 2;
    
    [ReadOnly]
    public Sprite _sprite;

    public void HandleEffect()
    {
        throw new System.NotImplementedException();
    }
}
