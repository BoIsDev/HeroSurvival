using UnityEngine;
public abstract class Spawn : MonoBehaviour
{
    
    public float spawnInterval = 2f; // Thời gian giữa mỗi lần spawn
    public int maxObjects = 20; // Số lượng tối đa đối tượng được spawn
    public int currentObjects = 0; // Số lượng đối tượng hiện tại đã spawn
    private float spawnTimer = 0f; // Thời gian đếm để spawn tiếp theo


    

    protected virtual void Update()
    {
        // Kiểm tra nếu chưa đạt tới số lượng tối đa và đã đến thời gian spawn tiếp theo
        if (currentObjects < maxObjects && Time.time >= spawnTimer)
        {
            // Spawn đối tượng
            SpawnObject();
            // Cập nhật thời gian spawn tiếp theo
            spawnTimer = Time.time + spawnInterval;
        }
    }

    public abstract void SpawnObject();
    
}
