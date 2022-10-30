using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelUp : MonoBehaviour
{
     public virtual void Clicked()
    {
        //Debug.Log("Level Up");
        //Transform player = GameObject.Find("PlayerManager").transform;
        //PlayerController playerController = player.GetComponent<PlayerController>();
        //playerController.playerLevel.LevelUp();
        PlayerController.instance.playerLevel.LevelUp();
    }
}
