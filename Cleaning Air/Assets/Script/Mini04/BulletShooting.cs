using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooting : MonoBehaviour
{
    public Transform FirePosition;
    public GameObject Bullet;
    public float BulletSpeed = 5;

    void Start()
    {
        InvokeRepeating("Shoot", 0f, 2f);
    }
    void Shoot()
    {
        GameObject bullet 
            = Instantiate(Bullet, FirePosition.position, 
                FirePosition.transform.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = FirePosition.forward * BulletSpeed;
    }
}
