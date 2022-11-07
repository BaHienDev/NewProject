using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByTime : Despawn
{
    public static DespawnByTime instance;
    public float timer = 0f;
    public float delay = 0.8f;

    private void Awake()
    {
        DespawnByTime.instance = this;
    }
    private void FixedUpdate()
    {
        this.DespawnByTiming();
    }
    public virtual void DespawnByTiming()
    {
        this.timer += Time.fixedDeltaTime;
        if (this.timer < this.delay) return;
        this.timer = 0;
        this.Despawning();
    }
}
