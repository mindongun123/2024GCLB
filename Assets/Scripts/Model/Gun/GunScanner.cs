using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;


public class GunScanner : MonoBehaviour, IGun, IEffectGun
{
    [Header("Data")]
    [ReadOnly]
    public EnumsNameGun nameGun = EnumsNameGun.GunScanner;
    [ReadOnly]
    public int _damage = 2;
    
    [ReadOnly]
    public Sprite _sprite;

    public void HandleEffect()
    {
        throw new System.NotImplementedException();
    }
}
