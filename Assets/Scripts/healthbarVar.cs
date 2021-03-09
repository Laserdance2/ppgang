using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarVar : MonoBehaviour
{
   // public int healthbarVarCounter;
   //public Text healthText;
    public Slider slider;
    public PlayerLives playerLives;
    public GameObject player;

    
    void Start()
    {

        
        playerLives = player.GetComponent<PlayerLives>();

        //healthbarVarCounter = playerLives.playerLiveCounter;
        slider.value = playerLives.playerLiveCounter;
        Debug.Log(playerLives.playerLiveCounter);

    }

    
    void Update()
    {
       // healthText.text = "Health: " + healthbarVarCounter.ToString();
        slider.value = playerLives.playerLiveCounter;
    }
}
