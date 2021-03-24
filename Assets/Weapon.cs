using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;
    float initDistToPlayer = -999;

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
        if (initDistToPlayer == -999)
        {
            initDistToPlayer = firePoint.localPosition.x;
        }
        Transform temp = firePoint;
        int rot = GameObject.Find("Player").GetComponent<Movement>().side;
       // firePoint.localPosition.Set(rot * initDistToPlayer, 0, 0);
       firePoint.localRotation.Set(0, 90 + 90 * rot, 0, 0);
        
        ;
		GameObject tempBullet = (GameObject)Instantiate(BulletPrefab, new Vector3(rot*initDistToPlayer + firePoint.position.x - initDistToPlayer, firePoint.position.y, firePoint.position.z), new Quaternion(0,90 + 90* -rot, 0, 0));
        tempBullet.tag = "bullet";
    }
}

//Instantiate(BulletPrefab, firePoint.position, Quaternion.FromToRotation(Vector3.left, Vector3.right));
