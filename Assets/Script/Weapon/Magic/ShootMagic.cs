using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMagic : MonoBehaviour
{
    [SerializeField] protected bool isShooting = true;   //Đang bắn = false; 
    public Transform OnHead; // vị trí nằm trên đầu player
    protected InputMoveHero inputMoveHero; // Thêm biến này để lưu tham chiếu
    private float timeStep = 1f; // time đợi để bắn

    private float timeDefault = 0f;
  
    void FixedUpdate()
    {
        TimeShoots();

        this.Shooting();
    }

   protected  void Shooting()
    {
        if (this.isShooting) return;
        timeDefault = 0f;

    // Khởi tạo prefab và lưu trữ tham chiếu đến instance
    GameObject spawnedObject = WeaponManager.Instance.GetObjectFromPool("MagicPool");
    if (spawnedObject != null)
    {
        // Thiết lập vị trí và hướng cho đạn
        spawnedObject.transform.position = OnHead.position;
        spawnedObject.transform.rotation = OnHead.rotation;

        // Kích hoạt đối tượng sau khi đã thiết lập vị trí và hướng
        spawnedObject.SetActive(true);
    }

    // Đảo trạng thái isShooting để chờ đợi lần bắn kế tiếp
    isShooting = !isShooting;
    }




    private void TimeShoots()
    {
        if(!this.isShooting) return;
        timeDefault += Time.deltaTime;
        if(timeDefault >= timeStep)
        {
            isShooting = !isShooting;
        }
    }
}
