using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootWeapon : BoDevMonoBehaviour
{
    [SerializeField] protected float shootDelay = 5f;
    [SerializeField] protected float shootTimer = 0f;   
     protected Transform spawnPos;
    protected Player player; // Khai báo player

    protected override void Awake()
    {
        player =FindObjectOfType<Player>();
        if(player == null) return; 
        spawnPos = player.transform; 
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        this.Shooting();
    }

    protected virtual void Shooting()
    {
        this.shootTimer += Time.deltaTime;
        if (this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0;
        Transform newBullet = SpawnWeapon.Instance.Spawn(GetObjType(), GetSpawnPosition(), spawnPos.rotation);
        if (newBullet == null) return;
        newBullet.gameObject.SetActive(true);
        // Debug.Log("Shooting");
    }
    protected abstract string GetObjType();

    // Cho phép ghi đè vị trí spawn
    protected virtual Vector3 GetSpawnPosition()
    {
        return player.transform.position;
    }

    // Cho phép ghi đè hướng spawn
    protected virtual Quaternion GetSpawnRotation()
    {
        return player.transform.rotation;
    }
      
}
