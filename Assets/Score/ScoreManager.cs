using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public List<Score> scores;

    private void Awake()
    {
        ScoreManager.instance = this;
    }

    public virtual void Add(string key, int value)
    {
        Score exitScore = this.Get(key); 
        if(exitScore == null)
        {
            this.AddNewScores(key, value);
            return;
        }
        exitScore.value += value;
    }

    public virtual bool Deduct(string key, int value)
    {
        Score exitScore = this.Get(key);
        if (exitScore == null) return false;
        int newValue = exitScore.value - value;
        if (newValue < 0) return false;
        exitScore.value = newValue;
        return true;

    }

    protected virtual void AddNewScores(string key, int value)
    {
        Score score = new()
        {
            key = key,
            value = value
        };
        this.scores.Add(score);
    }

    public virtual Score Get(string key)
    {
        foreach (Score score in this.scores)
        {
            if (score.key == key) return score;
        }
        return null;
    }
}
