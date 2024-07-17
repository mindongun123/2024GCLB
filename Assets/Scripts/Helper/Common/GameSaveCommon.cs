using System.Collections;
using System.Collections.Generic;
using MJGame.Extensions;
using UnityEngine;

public static class GameSaveCommon
{
    public static int Coin
    {
        get => PlayerPrefs.GetInt(ConstString.COIN, 0);
        set => PlayerPrefs.SetInt(ConstString.COIN, value);
    }

    public static int Level
    {
        get => PlayerPrefs.GetInt(ConstString.LEVEL, 0);
        set => PlayerPrefs.SetInt(ConstString.LEVEL, value);
    }

    public static List<Card> Card
    {
        get => MJGameSave.GetList<Card>(ConstString.CARD, new List<Card>());
        set => MJGameSave.SetList(ConstString.CARD, value);
    }
}
