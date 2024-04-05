using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : BoDevMonoBehaviour
{
    public Transform player; // Tham chiếu đến player
    public float moveSpeed = 1f; // Tốc độ di chuyển của enemy

    private Rigidbody2D rb;

    protected override void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").transform; // Tìm đối tượng Player bằng tag

    }

    protected override void Update()
    {
        if (player != null)
        {
            MoveTowardsPlayer();
            // checkFlipEnemy();
        }
    }

    protected virtual void MoveTowardsPlayer()
    {
        // Xác định hướng di chuyển
        Vector2 direction = (player.position - transform.position).normalized;
        // Di chuyển enemy theo hướng đã xác định
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);

    }


    // protected virtual void checkFlipEnemy()
    // {
    //     // Check if the enemy is to the right or left of the player and whether it needs flipping
    //     if(player.position.x > transform.position.x  && !FlipManager.Instance.isFacingRight || player.position.x < transform.position.x && FlipManager.Instance.isFacingRight)
    //     {
    //         FlipManager.Instance.FlipX(transform);
    //     }
    // }

}