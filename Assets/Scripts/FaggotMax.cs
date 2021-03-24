using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaggotMax : MonoBehaviour
{
    public int playerLiveCounter;
    public int damage = 20;

    public Slider slider;
    public GameObject player;

    void Start()
    {
        playerLiveCounter = 100;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        GameObject collider = hitInfo.gameObject;
        if (collider.tag == "enemyBullet")
        {
            TakeDamage(damage);

        }
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
        Application.Quit();
        GetComponent<Collider2D>().enabled = false;
    }

    private void Update()
    {
        //healthbarVarCounter = playerLives.playerLiveCounter;
        slider.value = playerLiveCounter;
    }
}
