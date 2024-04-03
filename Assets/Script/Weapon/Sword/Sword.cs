using UnityEngine;

public class Sword : BoDevMonoBehaviour, IWeapons
{
     private Rigidbody2D rbParent;

    protected override void Start()
    {
        base.Start();
        // Tìm và lấy thể hiện của Rigidbody2D từ phần tử cha
        rbParent = GetComponentInParent<Rigidbody2D>();
        if(rbParent == null)
        {
            Debug.LogError("Rigidbody2D không tồn tại trên phần tử cha");
            return;
        }

        transform.rotation = Quaternion.Euler(0, 0, 0); // Hướng ngang, không xoay
        ProcessBullet();
        // Debug.Log(GetSpeed +"Speead");
    }

    protected override void OnEnable()
    {
        // Đặt lại hướng và vận tốc mỗi khi đối tượng được kích hoạt.
        this.Start();
    }
    public string GetNameWeapons { get { return "Sword"; } }
    public float Dame { get { return 2f; } }
    public float GetSpeed { get { return 5f; } }

    public virtual void ProcessBullet()
    {
        if (FlipManager.Instance.isFacingRight)
        {
            rbParent.velocity = transform.right * GetSpeed;
        }
        else
        {
            rbParent.velocity = -transform.right * GetSpeed;
        }
    }

    
}