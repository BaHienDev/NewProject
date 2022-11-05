using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1DamageReceiver : EnemyDamageReceiver
{
    private void Reset()
    {
        this.maxHP = 3;
    }
}
