using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnEnemy : BoDevMonoBehaviour
{
  
    [SerializeField] protected float shootDelay = 5f;
    [SerializeField] protected float shootTimer = 0f;   
    [SerializeField] protected Transform spawnPos;
    protected Player player; // Khai báo player

    protected override void Awake()
    {
        base.Awake();

        player = FindObjectOfType<Player>();
        if(player == null) return; 
        spawnPos = player.transform; 
    }
    
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        this.SpawnEnemies();
        
    }

    protected virtual void SpawnEnemies()
    {
        this.shootTimer += Time.deltaTime;
        if (this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0;
        Transform enemies = SpawnEnemyDefault.Instance.Spawn(GetObjType(), GetSpawnPosition(), spawnPos.rotation);
        if (enemies == null) return;
        enemies.gameObject.SetActive(true);
        // Debug.Log("SpawnEnemys");
    }

    protected abstract string GetObjType();

    protected virtual Vector3 GetSpawnPosition()
    {
        // Lấy kích thước của camera
        float cameraHeight = Camera.main.orthographicSize;
        float cameraWidth = cameraHeight * Camera.main.aspect;

        // Random vị trí nằm bên ngoài vùng camera
        Vector3 spawnPosition = Vector3.zero;
        float buffer = 1.5f; // Khoảng cách buffer nằm ngoài vùng camera
        bool insideCameraBounds = true;

        do
        {
            // Random vị trí x và y
            float randomX = Random.Range(-cameraWidth - buffer, cameraWidth + buffer);
            float randomY = Random.Range(-cameraHeight - buffer, cameraHeight + buffer);

            // Kiểm tra xem vị trí này có nằm trong vùng camera không
            insideCameraBounds = randomX > -cameraWidth && randomX < cameraWidth && randomY > -cameraHeight && randomY < cameraHeight;

            // Nếu không nằm trong vùng camera, gán vị trí spawnPosition và thoát khỏi vòng lặp
            if (!insideCameraBounds)
            {
                spawnPosition = new Vector3(randomX, randomY, 0f);
            }
        } while (insideCameraBounds);

        return spawnPosition;

    }
}
