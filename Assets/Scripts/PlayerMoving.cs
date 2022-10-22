using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public Vector2 Positon;
    public float speed = 7f;
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
        Vector3 targetPos = new Vector3(this.Positon.x, this.Positon.y, transform.parent.position.z);
        Vector3 MovingPerFrame = Vector3.MoveTowards(transform.parent.position, targetPos, speed * Time.deltaTime);
        transform.parent.position = MovingPerFrame;
    }
    protected virtual void GetPositionByInput()
    {
        this.Positon = InputManager.instance.mousePos;
    }
}
