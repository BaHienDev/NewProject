using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public PlayerController playerController;
    public float attackDelay = 1f;
    public float fixedTimer = 0f;
    public float baseDelay = 1f;
    public float finalDelay = 1f;
    public float delayPerLevel = 0.05f;
    public float minDelay = 0.05f;
    public string bulletName = "PlayerBullet";

    protected virtual void Start()
    {
        this.playerController = transform.parent.GetComponent<PlayerController>();
    }
    protected virtual void FixedUpdate()
    {
        this.FixAttacking();
    }
    protected virtual void Attack()
    {
        Transform newBullet = BulletManager.instance.Spawn(this.bulletName, transform.position);
        BulletControl bulletControl = newBullet.GetComponent<BulletControl>();
        if (bulletControl == null) Debug.LogError("Missing BulletCtr in new Bullet");
        BulletDamSender damSender = bulletControl.bulletDamSender;
        //damSender.damage = this.GetDamage();
        newBullet.gameObject.SetActive(true);
    }

    protected virtual float GetDamage()
    {
        return this.playerController.playerLevel.level;
    }
    protected virtual void FixAttacking()
    {
        this.fixedTimer += Time.fixedDeltaTime;
        if (this.fixedTimer < this.Delay()) return;
        this.fixedTimer = 0;
        this.Attack();
    }
    protected virtual float Delay()
    {
        int level = this.playerController.playerLevel.level;
        this.finalDelay = this.baseDelay - (level * this.delayPerLevel);
        if (this.finalDelay < this.minDelay) this.finalDelay = this.minDelay;
        return this.finalDelay;
    }
}
