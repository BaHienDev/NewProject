using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    public Vector2 mousePos;
    public Vector3 worldPosition;

    private void Awake()
    {
        InputManager.instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.LoadMousePos();
    }
    protected virtual void LoadMousePos()
    {
        this.worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.mousePos.x = worldPosition.x;
        this.mousePos.y = worldPosition.y;
    }
}
