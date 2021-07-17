using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DuckBase : MonoBehaviour
{
    public abstract void Quack();
   
    public IFlyBehaiviour flyBehaiviour;

    public void Fly(Rigidbody rb)
    {
        flyBehaiviour.Fly(rb);
    }   
}
