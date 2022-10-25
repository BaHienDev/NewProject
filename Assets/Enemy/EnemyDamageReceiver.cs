using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DamReceiver
{
    protected override void Despawn()
    {
        base.Despawn();
        ScoreManager.instance.Add(ScoreType.EnemyKill.ToString(), 1);
        ScoreManager.instance.Add(ScoreType.Gold.ToString(), 1);
    }
}
