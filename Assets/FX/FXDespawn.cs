using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FXDespawn : Despawn
{
    public float timer = 0f;
    public float delay = 0.8f;

    private void FixedUpdate()
    {
        this.DespawnByTiming();
    }
    protected virtual void DespawnByTiming()
    {
        this.timer += Time.fixedDeltaTime;
        if (this.timer < this.delay) return;
        this.timer = 0;
        this.Despawning();
    }
}
