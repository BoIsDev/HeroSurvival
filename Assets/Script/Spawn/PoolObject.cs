using UnityEngine;

public abstract class PoolObject:MonoBehaviour
{
    public abstract GameObject GetObjectFromPool();
    public abstract void ReturnObjectToPool(GameObject obj);
}
