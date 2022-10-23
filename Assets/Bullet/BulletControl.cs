using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public Despawn despawn;

    private void Start()
    {
        this.despawn = transform.Find("Despawn").GetComponent<Despawn>();
    }
}
