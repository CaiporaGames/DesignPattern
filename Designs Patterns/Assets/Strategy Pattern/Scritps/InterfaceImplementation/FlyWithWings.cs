using UnityEngine;

public class FlyWithWings : IFlyBehaiviour
{
    public void Fly(Rigidbody rb)
    {
        Debug.Log("I am flying");
        rb.AddForce(Vector3.up, ForceMode.Impulse);
    }   
}
