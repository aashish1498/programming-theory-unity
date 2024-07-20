using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTarget : Target
{
    protected override void OnEnable()
    {
        speed /= 2;
        score /= 2;
        base.OnEnable();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    protected override void Move() // POLYMORPHISM
    {
        var verticalSpeed = rb.velocity.y +  Random.Range(-0.1f, 0.1f);
        rb.velocity = new Vector3(speed, verticalSpeed, 0);
    }
}
