using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : Level
{
    public static GameLevel instance;
    [Header("Game")]
    public float timer = 0;
    public float secondPerLevel = 10;

    protected virtual void Awake()
    {
        if (GameLevel.instance != null) Debug.LogError("Only 1 Game level allow");
        GameLevel.instance = this;
    }
    protected virtual void Start()
    {
        InvokeRepeating("Leveling", 2f, 1f);
    }
    protected virtual void Leveling()
    {
        this.timer += 1;
        this.level = Mathf.CeilToInt(this.timer / this.secondPerLevel);
    }
}
