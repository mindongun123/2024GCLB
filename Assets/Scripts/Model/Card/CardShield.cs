using System.Collections;
using System.Collections.Generic;
using MJGame;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class CardShield : MonoBehaviour, ICard, ICardHelp
{
    [ReadOnly]
    public EnumsNameCard _nameCard = EnumsNameCard.CardShield;


    public Sprite _sprite;

    public int _shield;

    private void Start()
    {
        GetComponent<Image>().sprite = _sprite;
    }
    public void DisableCard()
    {
        this.gameObject.SetActive(false);
    }

    public void OnClickCard()
    {
        if (Enums.stateGame != EnumsStateGame.Player) return;

        SingletonComponent<HandleGamePlay>.Instance.HandleCard(this);
    }

    public void PlayCardHelp()
    {
        throw new System.NotImplementedException();
    }
}
