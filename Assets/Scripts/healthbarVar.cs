
using UnityEngine;
using UnityEngine.UI;
public class healthbarVar : MonoBehaviour
{
    public int healthbarVarCounter;
    public Text healthText;
void Start(){

GameObject Player = GameObject.Find("Player");
playerLives playerLives = Player.GetComponent<playerLives>();

healthbarVarCounter = playerLives.playerLiveCounter;

}

    
    void Update()
    {
        healthText.text = "Health: " + healthbarVarCounter.ToString();
    }
}
