using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public PlayerLevel playerLevel;
    public PlayerModels playerModels;

    protected virtual void Awake()
    {
        PlayerController.instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.playerLevel = GetComponentInChildren<PlayerLevel>();
        this.playerModels = GetComponentInChildren<PlayerModels>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
