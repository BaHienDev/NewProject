using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    public List<Transform> prefabs;
    public Transform holder;
    public string holderName = "SpawnHolder";

    // Start is called before the first frame update
    private void Start()
    {
        this.LoadHolder();
        this.LoadBullets();
        this.HideAll();
    }

    protected virtual void LoadHolder()
    {
        this.holder = GameObject.Find(this.holderName).transform;
    }
    protected virtual void LoadBullets()
    {
        foreach (Transform prefab in transform)
        {
            this.prefabs.Add(prefab);
        }
    }
    public virtual Transform Spawn(string prefabName, Vector3 spawnPosition)
    {
        Transform prefab = this.GetBulletByName(prefabName);
        Transform newPrefab = Instantiate(prefab);
        newPrefab.position = spawnPosition;
        newPrefab.parent = this.holder;
        return newPrefab;
    }
    public virtual Transform GetBulletByName(string prefabName)
    {
        foreach (Transform prefab in this.prefabs)
        {
            if (prefab.name == prefabName) return prefab;
        }
        return null;
    }
    protected virtual void HideAll()
    {
        foreach (Transform prefab in this.prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }
}
