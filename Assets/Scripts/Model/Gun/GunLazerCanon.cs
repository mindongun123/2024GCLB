using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GunLazerCanon : MonoBehaviour, IGun, IEffectGun
{
    [Header("Data")]
    [ReadOnly]
    public EnumsNameGun nameGun = EnumsNameGun.GunLazerCanon;

    [ReadOnly]
    public int _damage = 1;
    
    [ReadOnly]
    public Sprite _sprite;

    public void HandleEffect()
    {
        throw new System.NotImplementedException();
    }
}
