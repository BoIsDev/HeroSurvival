using UnityEngine;

public class DamageSender : BoDevMonoBehaviour
{
    [SerializeField] protected int  damage = 1;
    protected virtual int DamageValue()
    {
        return this.damage;
    }

    public virtual void Send(Transform obj)
    {
        DamageReceiver damageReceiver = obj.GetComponentInChildren<DamageReceiver>();
        if (damageReceiver == null) return;
        this.Send(damageReceiver);
    }

    public virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(this.damage);
    }


    protected virtual void DestroyWeapon()
    {}
}
