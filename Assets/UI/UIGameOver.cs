using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    public Transform text;
    public Transform button;

    // Start is called before the first frame update
    private void Awake()
    {
        this.LoadGameOverUI();
    }
    private void FixedUpdate()
    {
        this.UpdateUI();
    }

    protected virtual void LoadGameOverUI()
    {
        this.text = transform.Find("TextGameover");
        this.button = transform.Find("ButtonReplay");
    }

    protected virtual void UpdateUI()
    {
        if (GameOver.instance.IsGameOver())
        {
            this.text.gameObject.SetActive(true);
            this.button.gameObject.SetActive(true);
            return;
        }
        this.text.gameObject.SetActive(false);
        this.button.gameObject.SetActive(false);
    }
    public virtual void Replay()
    {
        GameOver.instance.Replay();
    }
}
