using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public virtual void Despawning()
    {
        Destroy(transform.parent.gameObject);
    }
}
