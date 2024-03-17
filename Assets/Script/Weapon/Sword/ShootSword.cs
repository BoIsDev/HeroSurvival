using System.Collections;
using UnityEngine;
public class ShootSword : MonoBehaviour
{
    [SerializeField] protected bool isShooting = true;   //Đang bắn = false; 
    [SerializeField] public GameObject swordPrefab; // Đây là prefab của sword
    public Transform pointWeapinSword;
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
        GameObject swordInstance = Instantiate(swordPrefab, pointWeapinSword.position, rotation);
        
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
