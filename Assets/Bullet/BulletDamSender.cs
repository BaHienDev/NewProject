using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamSender : DamSender
{
    public BulletControl bulletControl;
    [SerializeField] protected string bulletSound = "BulletSound";

    private void Start()
    {
        this.bulletControl = transform.parent.GetComponent<BulletControl>();
        this.SpawnBulletSound();
    }
    protected override void Despawn()
    {
        this.bulletControl.despawn.Despawning();
    }
    protected virtual void SpawnBulletSound()
    {
        Vector3 pos = transform.position;
        Transform explosionSound = FXManager.instance.Spawn(this.bulletSound, pos);
        explosionSound.gameObject.SetActive(true);
    }
}
