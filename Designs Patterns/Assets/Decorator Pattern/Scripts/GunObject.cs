using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunObject : MonoBehaviour
{
    void Start()
    {
        Weapon sw = new SimpleGun();
        sw.Attack();
        print("----------------------------");

        sw = new IceGunDecorator(sw);
        sw.Attack();
        print("========================");
    }
}
