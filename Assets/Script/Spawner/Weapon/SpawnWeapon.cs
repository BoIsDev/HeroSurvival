using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : Spawner
{
    private static SpawnWeapon instance;
    public static SpawnWeapon Instance { get => instance; }

    public static List<string> weapons = new List<string>();

    protected override void Awake()
    {
        base.Awake();
        if (SpawnWeapon.instance != null) Debug.LogError("Only 1 BulletSpawner allow to exist");
        SpawnWeapon.instance = this;
       
    }

  
    public virtual void AddWeapon(string weapon)
    {
        if(weapons.Contains(weapon)) return;
        weapons.Add(weapon);
    }
   public virtual string GetNameObj(string nameObj)
    {
        foreach (string weapon in weapons)
        {
            if (weapon == nameObj)
            {
                return weapon;
            }
        }

       
        return null; // Trả về null nếu không tìm thấy
    }


    
}
