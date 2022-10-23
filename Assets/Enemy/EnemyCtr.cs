using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtr : MonoBehaviour
{
    public Despawn despawn;

    private void Start()
    {
        this.despawn = transform.GetComponentInChildren<Despawn>();
    }
}
