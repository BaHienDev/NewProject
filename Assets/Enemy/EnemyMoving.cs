using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MovingByCP
{
    public EnemyCtr enemyCtr;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        this.LoadEnemyCtr();
    }

    protected virtual void LoadEnemyCtr()
    {
        this.enemyCtr = transform.parent.GetComponent<EnemyCtr>();
    }
    protected override void Moving()
    {
        base.Moving();
        if (this.IsTheEndCP()) this.enemyCtr.despawn.Despawning();
    }
}
