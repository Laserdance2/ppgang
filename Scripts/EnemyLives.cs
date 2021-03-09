  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLives : MonoBehaviour
{
    public int enemyLiveCounter;
    void Start()
    {
        enemyLiveCounter= 30;
    }

   public void enemyTakeDamage(){
       //hier moet weer de collision enzo komen

       if(enemyLiveCounter <= 0){
           Die();
       }
   }
   
   void Die(){
       this.enabled = false;
        GetComponent<CapsuleCollider2D>().enabled = false;
   }
}
