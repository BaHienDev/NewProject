using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public float despawnLimit = 20f;
    public float distance = 0;
    public Transform mainCam;

    private void Start()
    {
        this.loadCam();
    }

    private void FixedUpdate()
    {
        this.CalculateDistance();
    }

    protected virtual void CalculateDistance()
    {
        this.distance = Vector3.Distance(transform.position, this.mainCam.position);
        if (this.distance > this.despawnLimit) this.Despawning();
    }
    public virtual void loadCam()
    {
        this.mainCam = GameObject.Find("Main Camera").transform;
    }
    public virtual void Despawning()
    {
        Destroy(transform.parent.gameObject);
    }
}
