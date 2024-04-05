using UnityEngine;

public class ShootMagic : ShootWeapon
{
    [SerializeField] private Vector3 offset = new Vector3(0f,1.5f, 0f);

 

    protected override void Start()
    {
        base.Start();
        SpawnWeapon.Instance.AddWeapon("Magic0");

    }

    // Ghi đè để thay đổi loại đạn
    protected override string GetObjType()
    {
        return this.SetObjectType();
    }

    // Ghi đè để thay đổi vị trí spawn
    protected override Vector3 GetSpawnPosition()
    {
        return player.transform.position + offset;
    }

    public virtual string SetObjectType()
    {
        return SpawnWeapon.Instance.GetNameObj("Magic0");

    } 
    
}
