using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinPool : PoolObject
{
     public GameObject goblinPoolPrefab;
    public int initialSize = 10;
    public Transform Holder;
    public Transform Prefabs;
    private List<GameObject> pool = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < initialSize; i++)
        {
            GameObject obj = InstantiateObject();
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public override GameObject GetObjectFromPool()
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
                
            }
        }
        GameObject newObj = InstantiateObject();
        pool.Add(newObj);
        return newObj;
    }

    public override void ReturnObjectToPool(GameObject obj)
    {
        obj.SetActive(false);
    }

    private GameObject InstantiateObject()
    {
        GameObject obj = Instantiate(goblinPoolPrefab);
         obj.transform.SetParent(Holder);  
        return obj;
    }
}
