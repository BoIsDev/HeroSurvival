using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class DeSpawnByDie : Despawn
{


    protected override bool CanDespawn()
    {
        return false;
    }
}
