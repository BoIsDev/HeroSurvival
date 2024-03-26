using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton1 : MonoBehaviour, IEnemy
{
    SkeletonSpawn skeletonSpawn;
    Player player;
    void Awake()
    {
        player = FindObjectOfType<Player>();
        skeletonSpawn = FindObjectOfType<SkeletonSpawn>();
    }
    public string SetNameEnemy() => "Skeleton1";

    public int SetHealthEnemy() => 20;

    public int SetArmorEnemy() => 5;

    public int SetExpEnemy() => 5; 

    public void SetDeadEnemy()
    {}
 

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("a");// Xử lý khi va chạm với đối tượng "Enemy" ở đây
            PoolManager.Instance.ReturnObjectToPool("SkeletonPool", gameObject);
            skeletonSpawn.currentObjects--;
        }    
    }
}
