using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingByCP : MonoBehaviour
{
    public Transform checkpointsPath;
    public List<Transform> checkpoints;
    public float speed = 1f;
    public float checkpointDistance = Mathf.Infinity;
    public int checkpointIndex = 0;
    public bool CPfinish;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        this.LoadCheckpoints();
    }

    private void Update()
    {
        this.MoveToNextCP();
        this.Moving();
    }

    protected virtual void LoadCheckpoints()
    {
        if (checkpoints.Count > 0) return;
        this.checkpointsPath = GameObject.Find("CPMoving").transform;
        foreach (Transform checkpoint in this.checkpointsPath)
        {
            this.checkpoints.Add(checkpoint);
        }
    }

    protected virtual void Moving()
    {
        float step = this.speed * Time.deltaTime;
        transform.parent.position = Vector3.MoveTowards(transform.parent.position, this.CurrentCheckPoint().position, step);
    }
    protected virtual Transform CurrentCheckPoint()
    {
        return this.checkpoints[checkpointIndex];
    }
    protected virtual void MoveToNextCP()
    {
        this.checkpointDistance = Vector3.Distance(transform.parent.position, this.CurrentCheckPoint().position);
        if (this.checkpointDistance <= 0.2f) this.checkpointIndex++;
        if (this.checkpointIndex >= this.checkpoints.Count)
        {
            this.checkpointIndex = this.checkpoints.Count - 1;
            this.CPfinish = true;
        }
    }
    public virtual bool IsTheEndCP()
    {
        return this.CPfinish;
    }
}
