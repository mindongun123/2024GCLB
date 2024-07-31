using System.Collections;
using System.Collections.Generic;
using MJGame;
using MJGame.Extensions;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class CardShuriken : MonoBehaviour, ICard, ICardHelp
{
    [ReadOnly]
    public EnumsNameCard _nameCard = EnumsNameCard.CardShuriken;

    public Sprite _sprite;
    private int[] damages = { 1, 2, 4 };
    [Header("Data")]
    public int _damage = 1;


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
        _damage = damages[Random.Range(0, damages.Length)];
        Mana = _mana;

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
