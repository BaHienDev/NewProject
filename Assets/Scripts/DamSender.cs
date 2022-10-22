using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamSender : MonoBehaviour
{
    public float Damage = 1;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        DamReceiver damageReceiver = other.GetComponent<DamReceiver>();
        if (damageReceiver == null) return;
        damageReceiver.Damaged(this.Damage);
        this.Despawn();
    }

    protected virtual void Despawn()
    {
        Destroy(transform.parent.gameObject);
    }
}
