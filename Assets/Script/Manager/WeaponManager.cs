using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    private static WeaponManager instance;
    public static WeaponManager Instance { get { return instance; } }
    
    public Dictionary<string, PoolObject> weaponPools = new Dictionary<string, PoolObject>();

    public MagicPool magicPool;
    public SwordPool swordPool;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        if (magicPool != null)
        {
            AddPoolWeapons("MagicPool", magicPool);
        }
        
        if (swordPool != null)  
        {
            AddPoolWeapons("SwordPool", swordPool);
        }
    }

    public void AddPoolWeapons(string key, PoolObject weaponPool)
    {
        if (!weaponPools.ContainsKey(key))
        {
            weaponPools.Add(key, weaponPool);
        }
        else
        {
            Debug.LogWarning("Pool with key " + key + " already exists.");
        }
    }

    public GameObject GetObjectFromPool(string key)
    {
        if (weaponPools.ContainsKey(key))
        {
            return weaponPools[key].GetObjectFromPool();
        }
        else
        {
            Debug.LogWarning("Pool with key " + key + " does not exist.");
            return null;
        }
    }

    public void ReturnObjectToPool(string key, GameObject obj)
    {
        if (weaponPools.ContainsKey(key))
        {
            weaponPools[key].ReturnObjectToPool(obj);
        }
        else
        {
            Debug.LogWarning("Pool with key " + key + " does not exist.");
        }
    }
}
