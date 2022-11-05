using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DamReceiver
{
    [Header("Enemy")]
    [SerializeField] protected string explosionName = "explosion";
    [SerializeField] protected string explosionSound = "explosionSound";
    [SerializeField] protected float finalMaxHP = 0;
    protected override void Despawn()
    {
        base.Despawn();
        this.SpawnExplosion();
        ScoreManager.instance.Add(ScoreType.EnemyKill.ToString(), 1);
        ScoreManager.instance.Add(ScoreType.Gold.ToString(), 1);
    }
    protected virtual void SpawnExplosion()
    {
        Vector3 pos = transform.position;
        Transform explosion = FXManager.instance.Spawn(this.explosionName, pos);
        explosion.gameObject.SetActive(true);
        Transform explosionSound = FXManager.instance.Spawn(this.explosionSound, pos);
        explosionSound.gameObject.SetActive(true);
    }
    public override float MaxHP()
    {
        float maxHP = base.MaxHP();
        int gameLevel = GameLevel.instance.CurrentLevel();
        this.finalMaxHP = maxHP + gameLevel;
        return this.finalMaxHP;
    }
}
