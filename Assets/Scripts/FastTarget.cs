using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTarget : Target
{
    protected override void OnEnable()
    {
        speed *= 2;
        score *= 2;
        base.OnEnable();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
