using System;
using System.Collections;
using DG.Tweening;
using MJGame;
using MJGame.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;

public class GameManager : SingletonComponent<GameManager>
{
    public int _turn = 0;

    private void Start()
    {
        Enums.stateGame = EnumsStateGame.Player;

        LoadingTurnCurrent();
    }
    public IEnumerator NextTurnIE()
    {
        /// <summary>
        ///  Doan nay co the la doan de chia la bai lai 
        /// </summary>
        yield return new WaitForSeconds(1f);
        Enums.stateGame = EnumsStateGame.Player;
        LoadingTurnCurrent();
        yield return null;
    }


    #region Test
    public MJGameText textTurnLoading;

    [Button]
    public void LoadingTurnCurrent()
    {
        textTurnLoading.TextLoading(Enums.stateGame.ToString());
    }
    #endregion
}

