using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickupable : BoDevMonoBehaviour
{
    [SerializeField] protected SphereCollider _collider;
  protected override void Update()
{
    if (transform.parent != null) // Kiểm tra xem có cha không
    {
        transform.position = transform.parent.position; // Cập nhật vị trí theo cha
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
}
