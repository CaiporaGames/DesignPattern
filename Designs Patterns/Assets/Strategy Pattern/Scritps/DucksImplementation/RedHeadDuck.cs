using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHeadDuck : DuckBase
{
    private void Start()
    {
        Quack();
    }

    public override void Quack()
    {
        Debug.Log("Red Head Quack!");
    }  
}
