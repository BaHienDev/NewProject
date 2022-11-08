using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("SelectMap");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("MainMenu");
    }
    public void EnterLevel1()
    {
        Application.LoadLevel("BattleField");
    }
    public void Aboutmenu()
    {
        Application.LoadLevel("Aboutmenu");
    }
}
