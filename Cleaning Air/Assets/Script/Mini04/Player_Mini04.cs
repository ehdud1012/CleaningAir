using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Mini04 : MonoBehaviour
{
    public GameObject Clear;
    public GameObject Fail;
   
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Clear"))
        {
            Player.TreeCount++;
            Destroy(hit.gameObject);
            Clear.SetActive(true);
            Player.Mini04_Clear = 1;
        }
        else if (hit.gameObject.CompareTag("Bullet"))
        {
            Fail.SetActive(true);
        }
    }
}
