using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : BoDevMonoBehaviour
{
   [SerializeField] protected DamageReceiver damageReceiver;
    public DamageReceiver DamageReceiver { get => damageReceiver; }
    [SerializeField] protected EnemyDeSpawn enemyDeSpawn;
    public EnemyDeSpawn EnemyDeSpawn { get => enemyDeSpawn; }

    
    [SerializeField] protected EnemySO enemySO;
    public EnemySO EnemySO => enemySO;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemySO();
        this.LoadDamageReceiver();
        this.LoadEnemyDeSpawnl();
      

    }

    protected virtual void LoadDamageReceiver()
    {
        if (this.damageReceiver != null) return;
        this.damageReceiver = transform.GetComponentInChildren<DamageReceiver>();
        Debug.Log(transform.name + ": LoadDamageSender", gameObject);
    }

     protected virtual void LoadEnemyDeSpawnl()
    {
        if (this.enemyDeSpawn != null) return;
        this.enemyDeSpawn = transform.GetComponentInChildren<EnemyDeSpawn>();
        Debug.Log(transform.name + ": LoadWeaponCtrl", gameObject);
    }

    protected virtual void LoadEnemySO()
    {
        if(this.enemySO != null) return;
        string resPath = "Enemy/" + transform.name;
        this.enemySO = Resources.Load<EnemySO>(resPath);
        Debug.LogWarning(transform.name + " LoandEnemySO" + resPath,gameObject); 
    }

}

