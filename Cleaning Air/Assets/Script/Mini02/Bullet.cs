using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static float damage = 30;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
