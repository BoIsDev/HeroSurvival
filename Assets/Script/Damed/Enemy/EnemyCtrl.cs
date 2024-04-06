using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : BoDevMonoBehaviour
{
   [SerializeField] protected DamageReceiver damageReceiver;
    public DamageReceiver DamageReceiver { get => damageReceiver; }
    [SerializeField] protected EnemyDeSpawn enemyDeSpawn;
    public EnemyDeSpawn EnemyDeSpawn { get => enemyDeSpawn; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
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

}

