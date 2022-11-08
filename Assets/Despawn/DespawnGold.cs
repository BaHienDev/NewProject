using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnGold : DespawnByTime
{
    private void FixedUpdate()
    {
        this.DespawnByTiming();
    }
    public override void DespawnByTiming()
    {
        DespawnByTime.instance.delay = 2f;
        base.DespawnByTiming();
    }
}
