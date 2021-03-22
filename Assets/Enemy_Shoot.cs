using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot : MonoBehaviour
{
    // Start is called before the first frame update
   public bool seePlayer;

   

   public void Shoot(){
       if(seePlayer){
           
       }

   }

   void FixedUpdate(){
             RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right);
       RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, Vector2.left);

       if ((hitLeft.collider != null) && (GameObject.Find("chinese").GetComponent<enemy_move>().MoveRight == false)){
           seePlayer = true;

       }
       else{
           seePlayer = false;
       }
    
    
    if((hitRight.collider != null) && (GameObject.Find("chinese").GetComponent<enemy_move>().MoveRight == true)){
           seePlayer = true;
       }
        else{
            seePlayer = false;
        }

       LayerMask mask = LayerMask.GetMask("Player");
   }
   
   
}
