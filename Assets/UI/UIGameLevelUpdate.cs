using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameLevelUpdate : MonoBehaviour
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
        int level = GameLevel.instance.CurrentLevel();
        this.Text.text = "Level:" + level;
    }
}
