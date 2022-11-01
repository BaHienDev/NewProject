using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public static BulletManager instance;
    public List<Transform> bullets;
    public Transform bulletHolder;
    public string holderName = "BulletHolder";
    private void Awake()
    {
        BulletManager.instance = this;
    }
    // Start is called before the first frame update
    private void Start()
    {
        this.LoadBulletHolder();
        this.LoadBullets();
        this.HideAll();
    }

    protected virtual void LoadBulletHolder()
    {
        this.bulletHolder = GameObject.Find(this.holderName).transform;
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
        newBullet.parent = this.bulletHolder;
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
