using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public Vector2 Position;
    public float speed = 7f;
    public Vector2 limitHorizon = new Vector2(-2.2f, 2.2f);
    public Vector2 limitVertical = new Vector2(4.5f, -4.5f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Move2Position();
        this.GetPositionByInput();
    }
    protected virtual void Move2Position()
    {
        Vector3 targetPos = new Vector3(this.Position.x, this.Position.y, transform.parent.position.z);
        Vector3 MovingPerFrame = Vector3.MoveTowards(transform.parent.position, targetPos, speed * Time.deltaTime);
        transform.parent.position = MovingPerFrame;
    }
    protected virtual void GetPositionByInput()
    {
        this.Position = InputManager.instance.mousePos;
        if (this.Position.x < this.limitHorizon.x) this.Position.x = this.limitHorizon.x;
        if (this.Position.x > this.limitHorizon.y) this.Position.x = this.limitHorizon.y;
        if (this.Position.y > this.limitVertical.x) this.Position.y = this.limitVertical.x;
        if (this.Position.y < this.limitVertical.y) this.Position.y = this.limitVertical.y;
    }
}
