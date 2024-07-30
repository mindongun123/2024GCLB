using MJGame;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class CardNormal : MonoBehaviour, ICard
{
    [ReadOnly]
    public EnumsNameCard _nameCard = EnumsNameCard.CardNormal;
    public CardSO cardData;

    public CardNormal(CardSO cardData)
    {
        this.cardData = cardData;
    }

    private void Start()
    {
        GetComponent<Image>().sprite = cardData._sprite;
    }

    public void OnClickCard()
    {
        if (Enums.stateGame != EnumsStateGame.Player) return;

        SingletonComponent<HandleGamePlay>.Instance.HandleCard(this);
    }

    public void DisableCard()
    {
        this.gameObject.SetActive(false);
    }
}
