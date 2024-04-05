using UnityEngine;

public class ShootSword : ShootWeapon
{
    [SerializeField] private Vector3 offset = new Vector3(1.5f, 0f, 0f);

  
    protected override void Start()
    {
        base.Start();
        SpawnWeapon.Instance.AddWeapon("Sword0");

    }
    // Ghi đè để thay đổi loại đạn
    protected override string GetObjType()
    {
        return this.SetObjectType();
    }

    // Ghi đè để thay đổi vị trí spawn
   protected override Vector3 GetSpawnPosition()
    {
         if(FlipManager.Instance.isFacingRight)
    {
        return player.transform.position + offset;
    }
    else
    {
        return player.transform.position - offset;
    }
    }

    protected override Quaternion GetSpawnRotation()
    {
        if(FlipManager.Instance.isFacingRight)
        {
            return Quaternion.Euler(0f, 0f, 0f); // Không xoay khi nhìn về bên phải
        }
        else
        {
            return Quaternion.Euler(0f,  180f,0f); // Xoay 180 độ khi nhìn về bên trái
        }
    }

    public virtual string SetObjectType()
    {
        return SpawnWeapon.Instance.GetNameObj("Sword0");

    }
}
