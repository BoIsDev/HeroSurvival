using UnityEngine;

public class ShootMagic : ShootWeapon
{
    [SerializeField] private Vector3 offset = new Vector3(0f,1.5f, 0f);

    protected override void Awake()
    {
        base.Awake();
        // Các thiết lập cụ thể cho ShootSword có thể được thêm vào đây
    }

    // Ghi đè để thay đổi loại đạn
    protected override string GetBulletType()
    {
        return SpawnWeapon.Magic0; // Giả sử đây là giá trị chuỗi đúng
    }

    // Ghi đè để thay đổi vị trí spawn
    protected override Vector3 GetSpawnPosition()
    {
        return player.transform.position + offset;
    }

    // Không cần ghi đè GetSpawnRotation() nếu không cần thiết
}
