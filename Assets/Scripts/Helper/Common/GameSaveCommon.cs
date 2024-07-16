using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSaveCommon
{
    public static int Coin
    {
        get => PlayerPrefs.GetInt(ConstString.COIN, 0);
        set => PlayerPrefs.SetInt(ConstString.COIN, value);
    }
}
