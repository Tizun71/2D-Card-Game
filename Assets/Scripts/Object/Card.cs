using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    [SerializeField] private string cardName;
    [SerializeField] private string cardRarity;
    [SerializeField] private string cardType;
    [SerializeField] private int cardCost;
    [SerializeField] private string cardDescription;

    public abstract void UseCard(Unit unit);
}
