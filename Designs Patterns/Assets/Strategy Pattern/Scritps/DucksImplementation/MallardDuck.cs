using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MallardDuck : DuckBase
{
     Rigidbody rb;
     private void Start()
     {
        rb = GetComponent<Rigidbody>();
        flyBehaiviour = new FlyWithWings();
        Quack();
     }

    public void SetFlying()
    {
        flyBehaiviour.Fly(rb);
       
    }
    public override void Quack()
    {
        Debug.Log("Mallard Quack!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetFlying();
        }
    }
   
}
