using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashCard : Card
{
    [SerializeField] private int damage;
    public override void UseCard(Unit unit)
    {
        // Damage the enemy
        unit.TakeDamage(damage);
    }
}
