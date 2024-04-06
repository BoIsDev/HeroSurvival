using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeSpawn : Despawn
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
        this.enemyCtrl =transform.parent.GetComponent<EnemyCtrl>();
        Debug.Log(transform.name + ": LoadEnemyCtrl", gameObject);
    }
    

    protected override bool CanDespawn()
    {
        return enemyCtrl.DamageReceiver.IsDead();
    }

    public override void DespawnObject()
    {
        SpawnEnemyDefault.Instance.Despawn(transform.parent); // Ensure to access gameObject for Despawn method.
    }
}
