using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyDefault : Spawner
{
    private static SpawnEnemyDefault instance;
    public static SpawnEnemyDefault Instance { get => instance; }

    public static List<string> enemys = new List<string>();

    protected override void Awake()
    {
        base.Awake();
        if (SpawnEnemyDefault.instance != null) Debug.LogError("Only 1 BulletSpawner allow to exist");
        SpawnEnemyDefault.instance = this;
       
    }
  
    public virtual void AddEnemy(string enemy)
    {
        if(enemys.Contains(enemy)) return;
        enemys.Add(enemy);
    }

   public virtual string GetNameObj(string nameObj)
    {
      
        foreach ( string enemy in enemys)
        {
            if(enemy == nameObj)
            {
                return enemy;
            }
        }
        return null; // Trả về null nếu không tìm thấy
    }


    
}
