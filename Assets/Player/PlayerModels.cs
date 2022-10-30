using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModels : MonoBehaviour
{
    public List<Transform> models;
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
        this.models[index].gameObject.SetActive(true);
    }
    
    protected virtual int LoadFromSaveGame()
    {
        return 0; //TODO NOT SAVE YET
    }
}
