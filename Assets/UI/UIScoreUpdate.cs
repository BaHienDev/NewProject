using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScoreUpdate : MonoBehaviour
{
    public static UIScoreUpdate instance;
    public TextMeshProUGUI textScore;


    protected virtual void Awake()
    {
        UIScoreUpdate.instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.LoadTextScore();
    }
    private void FixedUpdate()
    {
        this.UpdateScore();
    }

    protected virtual void LoadTextScore()
    {
        this.textScore = GetComponent<TextMeshProUGUI>();
    }

    protected virtual void UpdateScore()
    {
        Score score = ScoreManager.instance.Get(ScoreType.EnemyKill.ToString());
        int scoreValue = 0;
        if (score != null) scoreValue = score.value;
        this.textScore.text = "High Score " + scoreValue.ToString();
    }
}
