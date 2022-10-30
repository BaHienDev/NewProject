using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLevel : Level
{
    public PlayerController playerController;

    protected virtual void Start()
    {
        this.playerController = transform.parent.GetComponent<PlayerController>();
    }    
    public override void LevelUp(int add = 1)
    {
        if (!this.GoldDeduct())
        {
            Debug.LogWarning("Not enough gold");
            return;
        }    
        base.LevelUp(add);
        this.playerController.playerModels.ModelActive(this.level-1);
    }

    protected virtual bool GoldDeduct()
    {
        int cost = this.GetLevelUpCost();
        return ScoreManager.instance.Deduct(ScoreType.Gold.ToString(), cost);
    }
    protected virtual int GetLevelUpCost()
    {
        return this.level;
    }

}
