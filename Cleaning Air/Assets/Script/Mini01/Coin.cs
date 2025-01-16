using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float rotSpeed = 100f;
    public static int CoinCount = 0;
    void Update()
    {
        transform.Rotate(new Vector3(rotSpeed * Time.deltaTime, 0, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player01")
        {
            CoinCount++;
            Debug.Log(" 코인 개수 : " + CoinCount);
            Destroy(gameObject);
        }
    }
}
