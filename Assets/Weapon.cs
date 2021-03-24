﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootPlayer();
        }
    }

    void ShootPlayer() 
    {
        Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
    }
}
