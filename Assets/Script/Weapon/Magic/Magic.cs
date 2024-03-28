using UnityEngine;

public class Magic : MonoBehaviour, IWeapons
{
    // Tốc độ của Magic
    // Thể hiện của Rigidbody2D
    private Rigidbody2D rb;

    void Start()
    {
        // Lấy thể hiện của Rigidbody2D từ đối tượng
        rb = GetComponent<Rigidbody2D>();
        ProssetBullet();
    }
    // Triển khai phương thức từ interface
    public string GetNameWeapons { get { return "Magic"; } }
    public float Dame { get { return 2f; } }
    public float GetSpeed { get { return 5f; } }

    // Phương thức này được gọi khi đạn của Magic được bắn ra
    public void ProssetBullet()
    {   
        float   speed = 10f;
        // Thay đổi vận tốc của đạn để nó di chuyển theo hướng của đối tượng Magic
        rb.velocity = transform.up * speed;
    }

    // Phương thức Awake được sử dụng để khởi tạo đối tượng
  
}