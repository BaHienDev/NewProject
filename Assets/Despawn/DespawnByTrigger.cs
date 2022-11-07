using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DespawnByTrigger : Despawn
{
    [SerializeField] protected string explosionName = "explosion";
    [SerializeField] protected string explosionSound = "explosionSound";
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            this.Despawning();
            this.SpawnExplosion();
        }
    }
    protected virtual void SpawnExplosion()
    {
        Vector3 pos = transform.position;
        Transform explosion = FXManager.instance.Spawn(this.explosionName, pos);
        explosion.gameObject.SetActive(true);
        Transform explosionSound = FXManager.instance.Spawn(this.explosionSound, pos);
        explosionSound.gameObject.SetActive(true);
    }
}
