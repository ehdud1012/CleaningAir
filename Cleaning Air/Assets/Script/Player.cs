using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Vector3 playerPosition;

    public GameObject Map;
    public GameObject Reset;
    public GameObject XX_Popup;
    public GameObject Comment_Popup;
    public Text TreeLabel;

    public GameObject Mini01;
    public GameObject Mini02;
    public GameObject Mini03;
    public GameObject Mini04;

    public static int Mini01_Clear;
    public static int Mini02_Clear;
    public static int Mini03_Clear;
    public static int Mini04_Clear;
    public static int TreeCount;

    private void Start()
    {
        this.transform.Translate(playerPosition);
        Finish();
    }
    void Update()
    {
        playerPosition = this.transform.position;
        TreeLabel.text = (": " + TreeCount);
    }
    private void Finish()
    {
        if (TreeCount == 4)
        {
            Map.SetActive(true);
            Comment_Popup.SetActive(true);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("DeadLine"))
        {
            Reset.SetActive(true);
        }
        else if (hit.gameObject.CompareTag("House1"))
        {
            if (Mini01_Clear == 0)
            {
                Mini01.SetActive(true);
            }
            else
            {
                XX_Popup.SetActive(true);
            }
        }
        else if (hit.gameObject.CompareTag("House2"))
        {
            if (Mini02_Clear == 0)
            {
                Mini02.SetActive(true);
            }
            else
            {
                XX_Popup.SetActive(true);
            }
        }
        else if (hit.gameObject.CompareTag("House3"))
        {
            if (Mini03_Clear == 0)
            {
                Mini03.SetActive(true);
            }
            else
            {
                XX_Popup.SetActive(true);
            }
        }
        else if (hit.gameObject.CompareTag("House4"))
        {
            if (Mini04_Clear == 0)
            {
                Mini04.SetActive(true);
            }
            else
            {
                XX_Popup.SetActive(true);
            }
        }
    }
}
