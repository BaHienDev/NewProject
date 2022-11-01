using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : Spawner
{
    public static FXManager instance;

    private void Awake()
    {
        FXManager.instance = this;
    }
    protected virtual void Reset()
    {
        this.holderName = "FXHolder";
    }
   
}
