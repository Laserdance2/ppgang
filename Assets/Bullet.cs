using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
        this.tag = "bullet";
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        EnemyChinese enemyC = hitInfo.GetComponent<EnemyChinese>();
        if(enemyC != null)
        {
            enemyC.TakeDamage(damage);
        }
        if (hitInfo.tag != "turn" && hitInfo.tag != this.tag)
            Destroy(gameObject);
    }

}