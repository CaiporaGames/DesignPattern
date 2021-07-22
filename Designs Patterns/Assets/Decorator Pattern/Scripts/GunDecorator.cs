using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GunDecorator : Weapon
{
    private Weapon m_weapon;

    public GunDecorator(Weapon weapon)
    {
        m_weapon = weapon;
    }

    /// <summary>
    ///  Weapon attack
    /// </summary>
    public override void Attack()
    {
        m_weapon.Attack();
    }
}
