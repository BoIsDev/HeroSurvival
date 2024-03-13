using UnityEngine;

public class InputMoveHero : MonoBehaviour
{
    private static InputMoveHero instance;
    public static InputMoveHero Instance { get => instance; }

    protected Vector3 heroPos;

    public Vector3 HeroPos { get => heroPos; }

    private Rigidbody2D rb;
    protected float speedHero = 5f;
    private FlipManager flipManager;

    private void Awake()
    {
        flipManager = FindObjectOfType<FlipManager>();

        if (InputMoveHero.instance != null)
        {
            Debug.Log("Only 1 InputMoveHero instance allowed");
            Destroy(gameObject); // Destroy the duplicate instance
            return;
        }
        InputMoveHero.instance = this;
    }

    void Update()
    {
        MoveHero();
    }

    protected void MoveHero()
    {
        heroPos.x = Input.GetAxis("Horizontal");
        heroPos.y = Input.GetAxis("Vertical");
        heroPos.z = 0;
        transform.parent.position += heroPos * speedHero * Time.deltaTime;
        if (heroPos.x > 0 && !flipManager.isFacingRight || heroPos.x < 0 && flipManager.isFacingRight)
        {
            flipManager.FlipX(transform.parent);
        }
    }
}
