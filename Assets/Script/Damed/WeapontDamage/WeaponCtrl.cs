using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCtrl : BoDevMonoBehaviour
{
    [SerializeField] protected DamageSender damageSender;
    public DamageSender DamageSender { get => damageSender; }

    [SerializeField] protected WeaponDeSpawn weaponDeSpawn;
    public WeaponDeSpawn WeaponDeSpawn { get => weaponDeSpawn; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDamageSender();
        this.LoadWeaponDeSpawn();
    }

    protected virtual void LoadDamageSender()
    {
        if (this.damageSender != null) return;
        this.damageSender = transform.GetComponentInChildren<DamageSender>();
        Debug.Log(transform.name + ": LoadDamageSender", gameObject);
    }

    protected virtual void LoadWeaponDeSpawn()
    {
        if (this.weaponDeSpawn != null) return;
        this.weaponDeSpawn = transform.GetComponentInChildren<WeaponDeSpawn>();
        Debug.Log(transform.name + ": LoadweaponDeSpawn", gameObject);
    }

}
