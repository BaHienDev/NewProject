using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<EnemyCtr> enemies;
    public float timer = 0;
    public float delay = 2f;
    public float finalDelay = 1f;
    public float minDelay = 0.2f;
    public Transform enemyHolder;

    protected virtual void Start()
    {
        this.LoadEnemyHolder();
        this.LoadEnemies();
        this.HideAll();
    }

    protected virtual void LoadEnemyHolder()
    {
        this.enemyHolder = GameObject.Find("EnemyHolder").transform;
    }
    protected virtual void FixedUpdate()
    {
        this.Spawning();
    }

    protected virtual void LoadEnemies()
    {
        foreach (Transform enemy in transform)
        {
            this.enemies.Add(enemy.GetComponent<EnemyCtr>());
        }    
    }    

    protected virtual void HideAll()
    {
        foreach (EnemyCtr enemy in this.enemies)
        {
            enemy.gameObject.SetActive(false);
        }
    }
    protected virtual void Spawning()
    {
        this.timer += Time.fixedDeltaTime;
        if (this.timer < this.Delay()) return;
        this.timer = 0;
        GameObject newEnemy = Instantiate(this.GetEnemy().gameObject);
        newEnemy.name = this.GetEnemy().name;
        newEnemy.transform.parent = this.enemyHolder;
        newEnemy.SetActive(true);
    }

    protected virtual float Delay()
    {
        int gameLevel = GameLevel.instance.CurrentLevel();
        this.finalDelay = this.delay - (gameLevel * 0.05f);
        if (this.finalDelay < this.minDelay) this.finalDelay = this.minDelay;
        return this.finalDelay;
    }

    protected virtual EnemyCtr GetEnemy()
    {
        int rand = Random.Range(0, this.enemies.Count);
        return this.enemies[rand];
    }
}
