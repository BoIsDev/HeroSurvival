using UnityEngine;

public abstract class WeaponAbstract : BoDevMonoBehaviour
{
    [Header("Weapon Abtract")]
    [SerializeField] protected WeaponCtrl weaponCtrl;
    public WeaponCtrl WeaponCtrl { get => weaponCtrl; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadWeaponCtrl();
    }

    protected virtual void LoadWeaponCtrl()
    {
        if (this.weaponCtrl != null) return;
        this.weaponCtrl = transform.parent.GetComponent<WeaponCtrl>();
        Debug.Log(transform.name + ": LoadWeaponCtrl", gameObject);
    }
}
