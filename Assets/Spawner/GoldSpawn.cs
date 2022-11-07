using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpawn : Spawner
{
    public static GoldSpawn instance;

    private void Awake()
    {
        GoldSpawn.instance = this;
    }
    protected virtual void Reset()
    {
        this.holderName = "GoldHolder";
    }
}
