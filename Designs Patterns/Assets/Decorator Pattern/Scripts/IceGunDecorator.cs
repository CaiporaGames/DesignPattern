using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceGunDecorator : GunDecorator
{
    public IceGunDecorator(Weapon weapon) : base(weapon)
    {
    }

    private void Dizziness()
    {
        Debug.Log("dizziness...");
    }

    public override void Attack()
    {
        base.Attack();
        Dizziness();
    }
}
