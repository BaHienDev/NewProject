using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackDelay = 1f;
    public float fixedTimer = 0f;
    public float delay = 1f;
    // Start is called before the first frame update
    void Start()
    {
           //InvokeRepeating("Attack", 2f, this.attackDelay);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.FixAttacking();
    }
    protected virtual void Attack()
    {
       Transform newBullet = BulletManager.instance.Spawn("PlayerBullet", transform.position);
       newBullet.gameObject.SetActive(true);
    }
    protected virtual void FixAttacking()
    {
        this.fixedTimer += Time.fixedDeltaTime;
        if (this.fixedTimer < this.delay) return;
        this.fixedTimer = 0;
        this.Attack();
    }
}
