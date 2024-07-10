using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitDecorator : MonoBehaviour, IUnit
{
    IUnit unit;
    public void setCurrentHp(int hp)
    {
        unit.setCurrentHp(hp);
    }
    public void setCurrentShield(int shield)
    {
        unit.setCurrentShield(shield);
    }
}
