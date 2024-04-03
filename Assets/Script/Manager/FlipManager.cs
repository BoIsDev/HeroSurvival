using UnityEngine;

public class FlipManager : BoDevMonoBehaviour
{
    public bool isFacingRight = true;

    private static FlipManager instance;

    public static FlipManager Instance { get { return instance; } }

    protected override void Awake()
    {
        base.Awake();
        if (instance != null)
        {
            Debug.LogError("Only 1 FlipManager allow to exist");
            Destroy(gameObject); // Destroy duplicate instance
        }
        else
        {
            instance = this;
        }
    }

    public virtual void FlipX(Transform targetTransform)
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = targetTransform.localScale;
        scale.x *= -1;
        targetTransform.localScale = scale;
    }

    public virtual void FlipY(Transform targetTransform)
    {
        Vector3 scale = targetTransform.localScale;
        scale.y *= -1;
        targetTransform.localScale = scale;
    }
}
