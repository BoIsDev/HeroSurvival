using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public Transform player; // Tham chiếu đến player
    public float moveSpeed = 1f; // Tốc độ di chuyển của enemy

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").transform; // Tìm đối tượng Player bằng tag

    }

    private void Update()
    {
        if (player != null)
        {
            MoveTowardsPlayer();
        }
    }

    private void MoveTowardsPlayer()
    {
        // Xác định hướng di chuyển
        Vector2 direction = (player.position - transform.position).normalized;
        
        // Di chuyển enemy theo hướng đã xác định
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }
}
