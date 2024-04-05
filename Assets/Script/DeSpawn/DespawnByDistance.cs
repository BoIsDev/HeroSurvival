using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    // Start is called before the first frame update
    [SerializeField] protected float disLimit = 30f;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected Transform player;

    protected override void LoadComponents()
    {
        this.LoadPositionPlayer();
    }

    protected virtual void LoadPositionPlayer()
    {
        if (this.player != null) return;
        this.player = Transform.FindObjectOfType<Player>().transform;
        Debug.Log(transform.parent.name + ": LoadPositionPlayer", gameObject);
    }

    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(transform.position, this.player.position);
        if (this.distance > this.disLimit) return true;
        return false;
    }
}
