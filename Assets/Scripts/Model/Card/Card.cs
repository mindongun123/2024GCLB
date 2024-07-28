using MJGame;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour, ICard
{
    public CardDT cardData;

    public Card(CardDT cardData)
    {
        this.cardData = cardData;
    }

    private void Start()
    {
        GetComponent<Image>().sprite = cardData._sprite;
    }

    public void OnClickCard()
    {
        SingletonComponent<HandleGamePlay>.Instance.HandleCard(this);
    }

    public void DisableCard()
    {
        this.gameObject.SetActive(false);
    }
}
