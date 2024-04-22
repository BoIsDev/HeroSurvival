using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickupable : ItemAbstract
{
     [Header("Item Pickupable")]
    [SerializeField] protected SphereCollider _collider;
       protected override void Update()
{
    if (transform.parent != null) // Kiểm tra xem có cha không
    {
        transform.position = transform.parent.position; // Cập nhật vị trí theo cha
    }
}
    public static ItemCode String2ItemCode(string itemName)
    {
        try
        {
            return (ItemCode)System.Enum.Parse(typeof(ItemCode), itemName);
        }
        catch (ArgumentException e)
        {
            Debug.LogError(e.ToString());
            return ItemCode.NoItem;
        }
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTrigger();
    }

    protected virtual void LoadTrigger()
    {
        if (this._collider != null) return;
        this._collider = transform.GetComponent<SphereCollider>();
        this._collider.isTrigger = true;
        this._collider.radius = 0.2f;
        Debug.LogWarning(transform.name + " LoadTrigger", gameObject);
    }

    public virtual ItemCode GetItemCode()
    {
        return ItemPickupable.String2ItemCode(transform.parent.name);        
    }

    public virtual void Picked()
    {
        this.itemCtrl.ItemDespawn.DespawnObject();
    }
}
