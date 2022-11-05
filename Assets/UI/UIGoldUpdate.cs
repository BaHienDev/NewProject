using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGoldUpdate : MonoBehaviour
{
    public TextMeshProUGUI textGold;

    // Start is called before the first frame update
    void Start()
    {
        this.LoadTextGold();
    }
    private void FixedUpdate()
    {
        this.UpdateGold();
    }

    protected virtual void LoadTextGold()
    {
        this.textGold = GetComponent<TextMeshProUGUI>();
    }
    
    protected virtual void UpdateGold()
    {
        Score gold = ScoreManager.instance.Get(ScoreType.Gold.ToString());
        int goldValue = 0;
        if (gold != null) goldValue = gold.value;
        this.textGold.text = goldValue.ToString()+" Gold";
    }
}
