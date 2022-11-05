using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIEnemyPassedUpdate : MonoBehaviour
{
    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        this.LoadText();
    }
    private void FixedUpdate()
    {
        this.UpdateText();
    }

    protected virtual void LoadText()
    {
        this.Text = GetComponent<TextMeshProUGUI>();
    }

    protected virtual void UpdateText()
    {
        int remain = GameOver.instance.EnemyRemain();
        this.Text.text = remain.ToString();
    }
}
