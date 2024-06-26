using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(Rigidbody))]
public class ItemLooter : BoDevMonoBehaviour
{
    [SerializeField] protected Inventory inventory;
    [SerializeField] protected SphereCollider _collider;
    [SerializeField] protected Rigidbody _rigidbody;
    public Transform playerTransform; // Tham chiếu đến transform của player

    private static ItemLooter instance;
    public static ItemLooter Instance { get => instance; }
    protected override void Awake()
    {
        base.Awake();
        if (ItemLooter.instance != null) Debug.LogError("Only 1 ItemLooter allow to exist");
        ItemLooter.instance = this;
       
    }
    protected override void Update()
    {
        if (playerTransform != null)
        {
            transform.position = playerTransform.position; // Cập nhật vị trí theo player
        }
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInventory();
        this.LoadTrigger();
        this.LoadRigidbody();
    }

    protected virtual void LoadInventory()
    {
        if (this.inventory != null) return;
        this.inventory = transform.parent.GetComponent<Inventory>();
        Debug.LogWarning(transform.name + " LoadInventory", gameObject);
    }

    protected virtual void LoadTrigger()
    {
        if (this._collider != null) return;
        this._collider = transform.GetComponent<SphereCollider>();
        this._collider.isTrigger = true;
        this._collider.radius = 0.5f;
        Debug.LogWarning(transform.name + " LoadTrigger", gameObject);
    }

    protected virtual void LoadRigidbody()
    {
        if (this._rigidbody != null) return;
        this._rigidbody = transform.GetComponent<Rigidbody>();
        this._rigidbody.useGravity = false;
        this._rigidbody.isKinematic = true;
        Debug.LogWarning(transform.name + " LoadRigidbody", gameObject);
    }

  
    protected virtual void OnTriggerEnter(Collider collider)
    {

      ItemPickupable itemPickupable = collider.GetComponent<ItemPickupable>();
        if (itemPickupable == null) return;
        Debug.Log("Pickup", itemPickupable);
        ItemCode itemCode = itemPickupable.GetItemCode();
        if (this.inventory.AddItem(itemCode, 1))
        {
            itemPickupable.Picked();
            Debug.Log("ssss");
        }
    }
}
