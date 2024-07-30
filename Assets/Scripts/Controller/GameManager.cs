using System;
using System.Collections;
using MJGame;
using UnityEngine;

public class GameManager : SingletonComponent<GameManager>
{
    public int _turn = 0;

    private void Start()
    {
        Enums.stateGame = EnumsStateGame.Player;
    }
    public IEnumerator NextTurnIE()
    {
        /// <summary>
        ///  Doan nay co the la doan de chia la bai lai 
        /// </summary>
        yield return new WaitForSeconds(1f);
        Enums.stateGame = EnumsStateGame.Player;
        yield return null;
    }
}
