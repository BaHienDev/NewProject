using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamReceiver : MonoBehaviour
{
    [SerializeField] protected float hp = 0f;
    [SerializeField] protected float maxHP = 2f;

    private void OnEnable()
    {
        this.ResetHP();
    }
    
    protected virtual void ResetHP()
    {
        this.hp = this.MaxHP();
    }
    
    public virtual float MaxHP()
    {
        return this.maxHP;
    } 

    public virtual void Damaged(float damage)
    {
        this.hp -= damage;
        if (this.hp <= 0) this.hp = 0;
        this.Dying();

    }

    protected virtual void Dying()
    {
        if (this.IsAlive()) return;
        this.Despawn();
    }

    protected virtual bool IsAlive()
    {
        return this.hp > 0;
    }
    protected virtual void Despawn()
    {
        Destroy(transform.parent.gameObject);
    }
}
