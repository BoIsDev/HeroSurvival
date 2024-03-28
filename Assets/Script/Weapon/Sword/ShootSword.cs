using System.Collections;
using UnityEngine;
public class ShootSword : MonoBehaviour
{
    [SerializeField] protected bool isShooting = true;   //Đang bắn = false; 
    public Transform OnHand; //bắn vị trí bên cạnh player
    protected InputMoveHero inputMoveHero; // Thêm biến này để lưu tham chiếu
    private FlipManager flipManager;

    private float timeStep = 1f; // time đợi để bắn

    private float timeDefault = 0f;
    void Start()
    {
        flipManager = FindObjectOfType<FlipManager>();
    }

    void FixedUpdate()
    {
        TimeShoots();

        this.Shooting();
    }

   protected void Shooting()
    {
        if (this.isShooting) return;
        timeDefault = 0f;
        Quaternion rotation = flipManager.isFacingRight ? Quaternion.identity : Quaternion.Euler(0f, 180f, 0f);
        // Khởi tạo prefab và lưu trữ tham chiếu đến instance
        GameObject spawnedObject = WeaponManager.Instance.GetObjectFromPool("SwordPool");

        if (spawnedObject != null)
    {
        // Thiết lập vị trí và hướng cho đạn
        spawnedObject.transform.position = OnHand.position;
        spawnedObject.transform.rotation = rotation * OnHand.rotation; // Sử dụng phép nhân quaternion để kết hợp 2 rotations

        // Kích hoạt đối tượng sau khi đã thiết lập vị trí và hướng
        spawnedObject.SetActive(true);
    }

        
        // Chuyển instance vào coroutine
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
