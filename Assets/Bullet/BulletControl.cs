using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public Despawn despawn;
    public BulletDamSender bulletDamSender;

    private void Start()
    {
        this.despawn = transform.Find("Despawn").GetComponent<Despawn>();
        this.bulletDamSender = GetComponentInChildren<BulletDamSender>();
    }
}
