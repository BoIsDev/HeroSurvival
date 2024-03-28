using UnityEngine;

public class Sword : MonoBehaviour, IWeapons
{
    // Tốc độ của Sword
    // Thể hiện của Rigidbody2D
    private Rigidbody2D rb;
    void Start()
    {
        // Lấy thể hiện của Rigidbody2D từ đối tượng
        rb = GetComponent<Rigidbody2D>();
       ProssetBullet();
    }
    // Triển khai phương thức từ interface
    public string GetNameWeapons { get { return "Sword"; } }
    public float Dame { get { return 2f; } }
    public float GetSpeed { get { return 5f; } }

    // Phương thức này được gọi khi đạn của Sword được bắn ra
    public void ProssetBullet()
    {
      
        // Thay đổi vận tốc của đạn để nó di chuyển theo hướng của đối tượng Sword
        rb.velocity = transform.right * GetSpeed;
    }

    // Phương thức Awake được sử dụng để khởi tạo đối tượng
  
}