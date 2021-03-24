using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Weapon : MonoBehaviour
{
    public Transform firePointChinese;
    public GameObject BulletPrefab;

    void Update()
    {
        if(GameObject.Find("chinese").GetComponent<Enemy_Shoot>().seePlayer){
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(BulletPrefab, firePointChinese.position, firePointChinese.rotation);
    }
}
