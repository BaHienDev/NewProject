using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public static BulletManager instance;
    public List<Transform> bullets;
    private void Awake()
    {
        BulletManager.instance = this;
    }
    // Start is called before the first frame update
    private void Start()
    {
        this.LoadBullets();
        this.HideAll();
    }
    protected virtual void LoadBullets()
    {
        foreach(Transform bullet in transform)
        {
            this.bullets.Add(bullet);
        }    
    }    
    public virtual Transform Spawn(string bulletName, Vector3 spawnPosition)
    {
        Transform bulletPrefabs = this.GetBulletByName(bulletName);
        Transform newBullet = Instantiate(bulletPrefabs);
        newBullet.position = spawnPosition;
        return newBullet;
    }
    public virtual Transform GetBulletByName(string bulletName)
    {
        foreach (Transform bullet in this.bullets)
        {
            if (bullet.name == bulletName) return bullet;
        }
        return null;
    }
    protected virtual void HideAll()
    {
        foreach (Transform bullet in this.bullets)
        {
            bullet.gameObject.SetActive(false);
        }
    }

}
