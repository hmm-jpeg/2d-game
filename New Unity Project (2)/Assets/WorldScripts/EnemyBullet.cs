using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnCollisionEnter2D (Collision2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("Player"))
        {
            hitInfo.gameObject.GetComponent<PlayerController>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
