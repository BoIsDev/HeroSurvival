using UnityEngine;
public abstract class Spawn : MonoBehaviour
{
   
    public abstract void SpawnObject();
    

    protected abstract void SpawnTimer();

    protected abstract Vector3 GetRandomSpawnPosition();
  
}
