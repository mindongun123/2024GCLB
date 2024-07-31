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

    private int[] healths = { 5, 10, 15 };
    [Header("Data")]
    public int _helth = 5;// 5/10/15

    public int Mana
    {
        get => _mana;
        set => _mana = value;
    }
    public int _mana;

    private void Start()
    {
        GetComponent<Image>().sprite = _sprite;
        SetDataStart();
    }

    public void SetDataStart()
    {
        _helth = healths[Random.Range(0, healths.Length)];
        Mana = _mana;
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
