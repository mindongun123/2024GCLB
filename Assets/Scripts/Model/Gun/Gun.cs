using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [ShowInInspector, ReadOnly]
    public IGun gun;
    private void OnValidate()
    {
        if (gun == null)
        {
            gun = GetComponent<IGun>();
        }
    }

    private void OnEnable()
    {
        if (gun == null)
        {
            gun = GetComponent<IGun>();
        }
    }
}
