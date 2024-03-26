using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawn : Spawn
{
    // Start is called before the first frame update


    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    public override void SpawnObject()
    {
        // Lấy một đối tượng từ pool
        GameObject spawnedObject = PoolManager.Instance.GetObjectFromPool("SkeletonPool");
        if (spawnedObject != null)
        {
            // Đặt vị trí spawn của đối tượng
            spawnedObject.transform.position = transform.position;
            // Kích hoạt đối tượng
            spawnedObject.SetActive(true);
            // Tăng biến đếm số lượng đối tượng đã spawn
            currentObjects++;
        }
    }
}
