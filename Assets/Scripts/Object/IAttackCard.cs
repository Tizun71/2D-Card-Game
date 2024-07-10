using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackCard
{
    void reset();
    void setDamage(int damage);
    void setWeakness(int weakness);
}
