using UnityEngine;

public class Magic : BoDevMonoBehaviour, IWeapons
{
    // Tốc độ của Magic
    // Thể hiện của Rigidbody2D
    private Rigidbody2D rb;

    protected override void Start()
    {
        base.Start();
        // Lấy thể hiện của Rigidbody2D từ đối tượng
        rb = GetComponent<Rigidbody2D>();
        if(rb == null)
        {
            Debug.LogWarning("null");
        }
        ProcessBullet();
    }

    protected override void OnEnable()
    {
        this.Start();
    }

    public string GetNameWeapons { get { return "Magic"; } }
    public float Dame { get { return 2f; } }
    public float GetSpeed { get { return 5f; } }

    // Phương thức này được gọi khi đạn của Magic được bắn ra
    public virtual void ProcessBullet()
    {   
        float   speed = 10f;
        // Thay đổi vận tốc của đạn để nó di chuyển theo hướng của đối tượng Magic
        rb.velocity = transform.up * speed;
    }

  
}