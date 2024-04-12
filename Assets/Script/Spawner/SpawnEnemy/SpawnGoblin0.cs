using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGoblin0 : SpawnEnemy
{
     protected override void Start()
    {
        base.Start();
        Debug.Log("SpawnGoblin");
        SpawnEnemyDefault.Instance.AddEnemy("Goblin0");
     
   }


    protected override string GetObjType()
    {
        return this.SetObjectType();
    }
    
     public virtual string SetObjectType()
    {
        return SpawnEnemyDefault.Instance.GetNameObj("Goblin0");

    } 
}
