using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMagic : MonoBehaviour
{
    [SerializeField] protected bool isShooting = true;   //Đang bắn = false; 
    [SerializeField] public GameObject swordPrefab; // Đây là prefab của sword
    public Transform pointWeapinSword;
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
        GameObject swordInstance = Instantiate(swordPrefab, pointWeapinSword.position, Quaternion.identity);
        
        // Chuyển instance vào coroutine
        StartCoroutine(DestroySwordInstanceAfterDelay(swordInstance, 2));
        isShooting = !isShooting;
    }

    private IEnumerator DestroySwordInstanceAfterDelay(GameObject swordInstance, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(swordInstance); // Hủy instance sau một khoảng thời gian
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
