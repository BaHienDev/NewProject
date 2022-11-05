using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [Header("Level")]
    [SerializeField] protected int level = 1;

    public virtual void LevelUp(int add = 1)
    {
        this.level += add;
    }
    public virtual int CurrentLevel() 
    {
        return this.level;
    }
}
