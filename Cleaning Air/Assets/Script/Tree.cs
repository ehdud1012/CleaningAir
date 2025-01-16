using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tree : MonoBehaviour
{
    public GameObject TreePopUp;
    public GameObject TreeGrow;
    public GameObject GameClear;
    public GameObject TreeLabel;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            TreePopUp.SetActive(true);
            slider.value = 0.0f;
        }
    }
    public Slider slider;
    public float curValue = 0.0f;
    public float maxValue = 100.0f;
   
    public void TreeButton()
    {
        slider.value = (float)curValue / maxValue;
        if (curValue < maxValue)
        {
            curValue += 10;
        }
        else if(curValue == maxValue)
        {
            TreePopUp.SetActive(false);
            TreeGrow.SetActive(true);
            slider.value = 0.0f;
            Player.TreeCount--;
            if (Player.TreeCount == 0)
            {
                GameClear.SetActive(true);
                TreeLabel.SetActive(false);
            }
        }
    }
}
