using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : Spawner
{
    private static SpawnWeapon instance;
    public static SpawnWeapon Instance { get => instance; }

    public static string Magic0 = "Magic0";
    public static string Sword0 = "Sword0";

    protected override void Awake()
    {
        base.Awake();
        if (SpawnWeapon.instance != null) Debug.LogError("Only 1 BulletSpawner allow to exist");
        SpawnWeapon.instance = this;
    }
}
