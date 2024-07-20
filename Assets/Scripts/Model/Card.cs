using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardDT cardData;

    public Card(CardDT cardData)
    {
        this.cardData = cardData;
    }
}
