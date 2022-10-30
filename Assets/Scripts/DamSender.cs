using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamSender : MonoBehaviour
{
    public float damage = 5;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        DamReceiver damageReceiver = other.GetComponent<DamReceiver>();
        if (damageReceiver == null) return;
        damageReceiver.Damaged(this.damage);
        this.Despawn();
    }

    protected virtual void Despawn()
    {
        Destroy(transform.parent.gameObject);
    }
}
