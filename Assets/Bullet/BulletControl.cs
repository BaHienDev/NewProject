using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public Despawn despawn;
    public BulletDamSender bulletDamSender;

    private void Start()
    {
        this.LoadComponents();
    }
    protected virtual void OnEnable()
    {
        this.LoadComponents();
    }
    protected virtual void LoadComponents()
    {
        this.despawn = transform.Find("Despawn").GetComponent<Despawn>();
        this.bulletDamSender = GetComponentInChildren<BulletDamSender>();
    }
}
