using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinSpawn : Spawn
{   

    public Transform player; // Tham chiếu đến transform của đối tượng Player

    private  int maxObjects = 30;

    public float spawnInterval = 2f; // Thời gian giữa mỗi lần spawn
    public int currentObjects = 0; // Số lượng đối tượng hiện tại đã spawn
    protected float spawnTimer = 0f; // Thời gian đếm để spawn tiếp theo


    public float spawnRadius = 30f; // Đường kính vùng spawn

    // Update is called once per frame
    protected void Update()
    {
        SpawnTimer();
    }

    public override void SpawnObject()
    {
        GameObject spawnedObject = PoolManager.Instance.GetObjectFromPool("GoblinPool");
        if (spawnedObject != null)
        {
            // Tạo một vị trí ngẫu nhiên xung quanh Player với bán kính spawnRadius
            Vector3 spawnPosition = GetRandomSpawnPosition(); // Lưu trữ vị trí spawn

            // Đặt vị trí spawn của đối tượng
            spawnedObject.transform.position = spawnPosition;

            // Kích hoạt đối tượng
            spawnedObject.SetActive(true);

            // Tăng biến đếm số lượng đối tượng đã spawn
            currentObjects++;
        }
    }
     protected override void SpawnTimer()
    {
        if (currentObjects < maxObjects && Time.time >= spawnTimer)
        {
            // Spawn đối tượng
            SpawnObject();
            // Cập nhật thời gian spawn tiếp theo
            spawnTimer = Time.time + spawnInterval;
        }
    }

    protected override Vector3 GetRandomSpawnPosition()
    {
        Vector2 randomOffset = Random.insideUnitCircle * spawnRadius;
        return player.position + new Vector3(randomOffset.x, randomOffset.y, 0f);
    }
}
