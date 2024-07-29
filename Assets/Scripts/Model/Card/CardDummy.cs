using System.Collections;
using System.Collections.Generic;
using MJGame;
using MJGame.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;


public class CardDummy : MonoBehaviour, ICard, ICardHelp
{
    [ReadOnly]
    public EnumsNameCard _nameCard = EnumsNameCard.CardDummy;

    public Sprite _sprite;
    public int _helth;// 5/10/15

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
        SingletonComponent<HandleGamePlay>.Instance.HandleCard(this);
    }

    public void PlayCardHelp()
    {
        throw new System.NotImplementedException();
    }
}
