using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    Rigidbody2D rb; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
        gameObject.SetActive(false);

    }

}
