using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Min02 : MonoBehaviour
{
    public Transform FirePosition;
    public GameObject Bullet;
    public GameObject Clear;
    public GameObject Fail;
    public GameObject XX;

    public float BulletSpeed = 5;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        GameObject bullet
            = Instantiate(Bullet, FirePosition.position, FirePosition.transform.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        Destroy(bullet, 5.5f);
        rb.velocity = FirePosition.up * BulletSpeed;
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Clear"))
        {
            if (Enemy.EnemyDeath == 3)
            {
                Player.TreeCount++;
                Destroy(hit.gameObject);
                Clear.SetActive(true);
                Player.Mini02_Clear = 1;
            }
            else
            {
                Debug.Log(" 적을 모두 죽이십시오 ! ");
            }
        }
        else if (hit.gameObject.CompareTag("Enemy"))
        {
            Fail.SetActive(true);
            Enemy.EnemyDeath = 0;
        }
    }
}
