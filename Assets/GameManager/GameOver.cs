using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    [SerializeField] protected bool isGameOver = false;
    [SerializeField] protected int maxEnemyPassed = 10;
    [SerializeField] protected int enemyPassed = 0;


    protected virtual void Awake()
    {
        if (GameOver.instance != null) Debug.LogError("Only 1 Game Over allow");
        GameOver.instance = this;
    } 

    protected virtual void FixedUpdate()
    {
        this.UpdateEnemyPassed();
    }

    protected virtual void UpdateEnemyPassed()
    {
        Score enemyPassedScore = ScoreManager.instance.Get(ScoreType.EnemyPassed.ToString());
        if (enemyPassedScore == null) this.enemyPassed = 0;
        else this.enemyPassed = enemyPassedScore.value;
        if (this.enemyPassed >= this.maxEnemyPassed) this.isGameOver = true;
    }

    public virtual bool IsGameOver()
    {
        return this.isGameOver;
    }
    public virtual void Replay()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public virtual int EnemyRemain()
    {
        return this.maxEnemyPassed - this.enemyPassed;
    }
}
