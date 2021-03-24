using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int playerLiveCounter;
    void Start()
    {
        playerLiveCounter = 100;
    }
    
     public void TakeDamage (int damage)
    {
        playerLiveCounter -= damage;

        if (playerLiveCounter <=0)
        {
            Die();
        }
    }

    void Die(){
        Debug.Log("Player died");

        this.enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }
}
