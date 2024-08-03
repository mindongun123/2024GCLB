using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GunRifle : MonoBehaviour, IGun, IEffectGun
{
    [Header("Data")]
    [ReadOnly]
    public EnumsNameGun nameGun = EnumsNameGun.GunRifle;
    [ReadOnly]
    public int _damage = 8;
    
    [ReadOnly]
    public Sprite _sprite;

    public void HandleEffect()
    {
        throw new System.NotImplementedException();
    }
}