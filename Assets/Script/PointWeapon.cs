using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointWeapon : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;   
    [SerializeField] public GameObject swordPrefab; // Đây là prefab của sword
    public Transform target;
    private FlipManager flipManager;

    void Start()
    {
        flipManager = FindObjectOfType<FlipManager>();
    }

    void FixedUpdate()
    {
        this.Shooting();
    }

   protected virtual void Shooting()
    {
        if (!this.isShooting) return;

        Quaternion rotation = flipManager.isFacingRight ? Quaternion.identity : Quaternion.Euler(0f, 180f, 0f);
        // Khởi tạo prefab và lưu trữ tham chiếu đến instance
        GameObject swordInstance = Instantiate(swordPrefab, target.position, rotation);
        
        // Chuyển instance vào coroutine
        StartCoroutine(DestroySwordInstanceAfterDelay(swordInstance, 2));
    }

    private IEnumerator DestroySwordInstanceAfterDelay(GameObject swordInstance, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(swordInstance); // Hủy instance sau một khoảng thời gian
    }


    

}
