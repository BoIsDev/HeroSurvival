using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSkeleton : SpawnEnemy
{

    protected override void Start()
    {
        base.Start();
        // Debug.Log("SpawnSkeleton");
        SpawnEnemyDefault.Instance.AddEnemy("Skeleton0");
     
   }


    protected override string GetObjType()
    {
        return this.SetObjectType();
    }
    
     public virtual string SetObjectType()
    {
        return SpawnEnemyDefault.Instance.GetNameObj("Skeleton0");

    } 
}

