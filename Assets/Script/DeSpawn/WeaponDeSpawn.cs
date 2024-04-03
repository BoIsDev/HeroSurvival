using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDeSpawn : DespawnByDistance
{
    // Start is called before the first frame update
   protected override void DespawnObject()
   {
        SpawnWeapon.Instance.Despawn(transform.parent);
   }
}
