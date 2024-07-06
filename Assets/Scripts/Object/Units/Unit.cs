using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private string unitName;

    [SerializeField] private int unitMaxHp;
    [SerializeField] private int unitCurrentHp;

    [SerializeField] private int unitShield;

    public void TakeDamage(int damage)
    {
        unitCurrentHp -= damage;
        if (unitCurrentHp <= 0)
        {

        }
    }

    public void GainShield(int shield)
    {
        unitShield += shield;
    }

    public void Die()
    {
        Debug.Log(unitName + "is death");
    }
}
