using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private static PoolManager instance;
    public static PoolManager Instance { get { return instance; } }

    public Dictionary<string, PoolObject> pools = new Dictionary<string, PoolObject>();

    public SkeletonPool skeletonPool;
    private  void Awake()
    {
        // Add pool for Skeleton
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
         if (skeletonPool != null)
        {
            AddPool("SkeletonPool", skeletonPool);
        }    
    }

    public void AddPool(string key, PoolObject pool)
    {
        if (!pools.ContainsKey(key))
        {
            pools.Add(key, pool);
            Debug.Log("add");
        }
        else
        {
            Debug.LogWarning("Pool with key " + key + " already exists.");
        }
    }

    public GameObject GetObjectFromPool(string key)
    {
        if (pools.ContainsKey(key))
        {
            return pools[key].GetObjectFromPool();
        }
        else
        {
            Debug.LogWarning("Pool with key " + key + " does not exist.");
            return null;
        }
    }

    public void ReturnObjectToPool(string key, GameObject obj)
    {
        if (pools.ContainsKey(key))
        {
            pools[key].ReturnObjectToPool(obj);
        }
        else
        {
            Debug.LogWarning("Pool with key " + key + " does not exist.");
        }
    }
}
