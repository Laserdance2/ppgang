using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Weapon : MonoBehaviour
{
    
public Transform firePoint;
public GameObject bulletPrefab;


    void Update()
    {
        if(GameObject.Find("chinese").GetComponent<Enemy_Shoot>().seePlayer){
            Shoot();
        }
    }

    void Shoot(){
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
