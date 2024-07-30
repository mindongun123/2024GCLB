using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GunElectric : MonoBehaviour, IGun
{
    [Header("Data")]
    [ReadOnly]
    public EnumsNameGun nameGun = EnumsNameGun.GunElectric;
    [ReadOnly]
    public int _damage = 1;

    [ReadOnly]
    public Sprite _sprite;

}
