using UnityEngine;

public class FlipManager : MonoBehaviour
{
    public bool isFacingRight = true;

    public void FlipX(Transform targetTransform)
    {
        isFacingRight =!isFacingRight;
        Vector3 scale = targetTransform.localScale;
        scale.x *= -1;
        targetTransform.localScale = scale;
    }

    public void FlipY(Transform targetTransform)
    {
        Vector3 scale = targetTransform.localScale;
        scale.y *= -1;
        targetTransform.localScale = scale;
    }
}
