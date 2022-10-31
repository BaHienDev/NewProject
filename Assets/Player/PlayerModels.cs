using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModels : MonoBehaviour
{
    [SerializeField] protected List<Transform> models;
    [SerializeField] protected List<Transform> strikePoint;
    public int modelIndex = 0;
    public string strikePointHolderName = "StrikePoint";
    // Start is called before the first frame update
    protected virtual void Start()
    {
        this.LoadModels();
        int lastIndex = this.LoadFromSaveGame();
        this.ModelActive(lastIndex);
    }

    protected virtual void LoadModels()
    {
        foreach(Transform child in transform)
        {
            this.models.Add(child);
        }
    }
    protected virtual void HideAll()
    {
        foreach(Transform model in this.models)
        {
            model.gameObject.SetActive(false);
        }
    }
    public virtual void ModelActive(int index)
    {
        this.HideAll();
        if (index >= this.models.Count) index = this.models.Count - 1;
        this.modelIndex = index;
        this.CurrentModel().gameObject.SetActive(true);
        this.LoadStrikePoint();
    }
    
    protected virtual int LoadFromSaveGame()
    {
        return 0; //TODO NOT SAVE YET
    }
    protected virtual void LoadStrikePoint()
    {
        this.strikePoint.Clear();
        Transform currentModel = this.CurrentModel();
        Transform strikePointHolder = currentModel.Find(this.strikePointHolderName);
        if (strikePointHolder == null) return;
        foreach (Transform child in strikePointHolder)
        {
            this.strikePoint.Add(child);
        }
    }
    public virtual Transform CurrentModel()
    {
        return this.models[this.modelIndex];
    }
    public virtual List<Transform> StrikePoints()
    {
        return this.strikePoint;
    }
}
