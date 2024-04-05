using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaPonDamege : DamageSender
{

  [SerializeField] protected WeaponCtrl weaponCtrl;
    public WeaponCtrl WeaponCtrl { get => weaponCtrl; }

     protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadWeaponCtrl();
    }
    protected override int DamageValue()
    {
        return 20;
    }

    protected virtual void LoadWeaponCtrl()
    {
        if (this.weaponCtrl != null) return;
        this.weaponCtrl = transform.parent.GetComponent<WeaponCtrl>();
        Debug.Log(transform.name + ": LoadWeaponCtrl", gameObject);
    }

       public override void Send(DamageReceiver damageReceiver)
    {
        Debug.LogWarning("Weapon");
        base.Send(damageReceiver);
        this.DestroyWeapon();
    }


    protected override void DestroyWeapon()
    {
        Debug.LogWarning("DestroyWeapon");
        this.weaponCtrl.WeaponDeSpawn.DespawnObject();
    }
}
