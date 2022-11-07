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
        DespawnByTime.instance.delay = 4f;
        base.DespawnByTiming();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.Despawning();
            ScoreManager.instance.Add(ScoreType.Gold.ToString(), 5);
        }
    }

}
