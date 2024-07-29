using System.Collections;
using System.Collections.Generic;
using MJGame;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class CardShuriken : MonoBehaviour, ICard, ICardHelp
{
    [ReadOnly]
    public EnumsNameCard _nameCard = EnumsNameCard.CardShuriken;

    public Sprite _sprite;

    public int _damage;//1/2/4

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
