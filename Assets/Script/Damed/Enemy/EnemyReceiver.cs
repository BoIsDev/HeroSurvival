using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReceiver : DamageReceiver
{
    [SerializeField] protected EnemyCtrl enemyCtrl;
    public EnemyCtrl EnemyCtrl { get => enemyCtrl; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
    }   
    protected virtual void LoadEnemyCtrl()
    {
        if (this.enemyCtrl != null) return;
        this.enemyCtrl = transform.parent.GetComponent<EnemyCtrl>();
        Debug.Log(transform.name + ": LoadWeaponCtrl", gameObject);
    }

    protected override void OnDead()
    {
        this.enemyCtrl.EnemyDeSpawn.DespawnObject();
        Debug.Log("enemy DeSpawn OnDead");
    }


}
