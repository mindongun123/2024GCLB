using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GunElectric : MonoBehaviour, IGun, IEffectGun
{
    [Header("Data")]
    [ReadOnly]
    public EnumsNameGun nameGun = EnumsNameGun.GunElectric;
    [ReadOnly]
    public int _damage = 1;
    [ReadOnly]
    public Sprite _sprite;

    #region  Effect


    public void HandleEffect()
    {
          
    }
    #endregion
}
