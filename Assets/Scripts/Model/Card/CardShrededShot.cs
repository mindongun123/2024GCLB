using System.Collections;
using System.Collections.Generic;
using MJGame;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class CardShrededShot : MonoBehaviour, ICard,ICardHelp
{
    [ReadOnly]
    public EnumsNameCard _nameCard= EnumsNameCard.CardShrededShot;
    public Sprite _sprite;

    public int _damageSub;
    public int _damageAdd;


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
