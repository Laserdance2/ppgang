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

    void Start(){
    shootCooldown = 0;
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
            canShoot = false;
        }

        
        
    }

    void ChangeSprite(){
        spriteRenderer.sprite = newSprite;
    }
    void Shoot()
    {
        ChangeSprite();
        Instantiate(BulletPrefab, firePointChinese.position, firePointChinese.rotation);
    }
}
