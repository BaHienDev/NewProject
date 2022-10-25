using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<EnemyCtr> enemies;
    public float timer = 0;
    public float delay = 2f;
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
        if (this.timer < this.delay) return;
        this.timer = 0;
        GameObject newEnemy = Instantiate(this.GetEnemy().gameObject);
        newEnemy.name = this.GetEnemy().name;
        newEnemy.transform.parent = this.enemyHolder;
        newEnemy.SetActive(true);
    }
    protected virtual EnemyCtr GetEnemy()
    {
        return this.enemies[0];
    }
}
