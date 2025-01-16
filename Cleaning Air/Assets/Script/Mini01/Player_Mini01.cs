using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Mini01 : MonoBehaviour
{
    public GameObject Clear;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Clear"))
        {
            if (Coin.CoinCount == 10)
            {
                Player.TreeCount++;
                Destroy(hit.gameObject);
                Clear.SetActive(true);
                Player.Mini01_Clear = 1;
            }
            else
            {
                Debug.Log("코인이 모자랍니다 !");
            }
        }
    }
}
