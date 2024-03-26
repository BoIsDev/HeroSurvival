using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Danh sách các prefab của quái vật
    public float[] spawnRates; // Tỷ lệ spawm của mỗi loại quái vật
    private float totalSpawnRate; // Tổng tỷ lệ spawm của tất cả các loại quái vật

    private void Start()
    {
        // Tính tổng tỷ lệ spawm của tất cả các loại quái vật
        foreach (float rate in spawnRates)
        {
            totalSpawnRate += rate;
        }
    }

    // Phương thức này được gọi để chọn một loại quái vật để spawm dựa trên tỷ lệ spawm
    public GameObject GetRandomEnemyPrefab()
    {
        float randomValue = Random.Range(0f, totalSpawnRate);
        float sum = 0f;
        for (int i = 0; i < enemyPrefabs.Length; i++)
        {
            sum += spawnRates[i];
            if (randomValue <= sum)
            {
                return enemyPrefabs[i];
            }
        }
        // Trường hợp này không xảy ra nếu tỷ lệ spawm đã được thiết lập chính xác
        Debug.LogError("No enemy prefab selected.");
        return null;
    }
}
