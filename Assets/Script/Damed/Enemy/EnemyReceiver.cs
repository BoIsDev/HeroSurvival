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
        this.OnDeadDropItems();
        Debug.Log("enemy DeSpawn OnDead"); 
        
    }

    protected virtual void OnDeadDropItems()
    {
        Vector3 posDrop = transform.position;
        Quaternion rotDrop = Quaternion.identity;   
        ItemDropSpawner.Instance.Drop(this.enemyCtrl.EnemySO.dropList,posDrop,rotDrop);
        Debug.LogWarning(this.enemyCtrl.EnemySO.dropList);
    }
    protected override void Reborn()
    {
        this.hpMax = this.enemyCtrl.EnemySO.hpMax;
        base.Reborn();
    }

}
