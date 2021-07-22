using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGun : Weapon
{
    /// <summary>
    ///  Attack method
    /// </summary>
    public override void Attack()
    {
        Debug.Log("Sword attack!");
    }
}
