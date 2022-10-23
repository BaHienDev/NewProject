using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamSender : DamSender
{
    public BulletControl bulletControl;

    private void Start()
    {
        this.bulletControl = transform.parent.GetComponent<BulletControl>();
    }
    protected override void Despawn()
    {
        this.bulletControl.despawn.Despawning();
    }
}
