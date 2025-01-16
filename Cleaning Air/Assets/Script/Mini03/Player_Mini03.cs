using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Mini03 : MonoBehaviour
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
            Player.Mini03_Clear = 1;
        }
        else if (hit.gameObject.CompareTag("Bar"))
        {
            Destroy(hit.gameObject);
            Fail.SetActive(true);
        }
    }
}
