using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Weapon : MonoBehaviour
{
    public Transform firePointChinese;
    public GameObject BulletPrefab;
    public float shootCooldown;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public bool canShoot;
    public float initDistToEnemy = -999;

    void Start(){
    shootCooldown = -2;
    spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        shootCooldown += Time.deltaTime;

        if(shootCooldown >= 1){
            canShoot = true;
        }
        else{
            canShoot = false;
        }

        if((GameObject.Find("chinese").GetComponent<Enemy_Shoot>().seePlayer) && (canShoot)){
            Shoot();
            shootCooldown = 0;
        }

        
        
    }

    void ChangeSprite(){
        spriteRenderer.sprite = newSprite;
    }
    void Shoot()
    {
        ChangeSprite();
        

        // if (initDistToEnemy == -999)
        //{
            initDistToEnemy = firePointChinese.localPosition.x;
        //}
        int rot;
        if(GameObject.Find("chinese").GetComponent<enemy_move>().MoveRight){
            rot = 1;
        }
        else{
            rot = -1;
        }
       firePointChinese.localPosition.Set(rot * initDistToEnemy, 0, 0);
       firePointChinese.localRotation.Set(0, 90 + 90 * rot, 0, 0);
       GameObject tempBullet = (GameObject)Instantiate(BulletPrefab, new Vector3(rot*initDistToEnemy + firePointChinese.position.x - initDistToEnemy, firePointChinese.position.y, firePointChinese.position.z), new Quaternion(0,90 + 90* -rot, 0, 0));
       tempBullet.tag = "enemyBullet";
    }
}
