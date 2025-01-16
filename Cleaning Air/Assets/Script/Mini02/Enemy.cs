using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent nav;
    private float maxHealth = 100;
    private float curHealth;
    public Transform player;
    public static int EnemyDeath = 0;

    Rigidbody rigid;
    CapsuleCollider capsuleCollider;
    private void Start()
    {
        curHealth = maxHealth;
        nav = GetComponent<NavMeshAgent>();
        rigid = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>();
    }
    private void Update()
    {
        nav.destination = player.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            curHealth -= Bullet.damage;
            Debug.Log("Range : " + curHealth);

            if (curHealth <= 0)
            {
                Destroy(gameObject);
                EnemyDeath++;
            }
        }
    }
}
