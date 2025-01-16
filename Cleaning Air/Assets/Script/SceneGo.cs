using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneGo : MonoBehaviour
{
    public void MainSceneGo()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void GameSceneGo()
    {
        SceneManager.LoadScene("GameScene");

        Player.Mini01_Clear = 0;
        Player.Mini02_Clear = 0;
        Player.Mini03_Clear = 0;
        Player.Mini04_Clear = 0;
        Player.TreeCount = 0;
    }
    public void ReturnGameSceneGo()
    {
        
        this.transform.position = Player.playerPosition;
        SceneManager.LoadScene("GameScene");
    }
    public void Mini01SceneGo()
    {
        SceneManager.LoadScene("MiniGame01");
    }
    public void Mini02SceneGo()
    {
        SceneManager.LoadScene("MiniGame02");
    }
    public void Mini03SceneGo()
    {
        SceneManager.LoadScene("MiniGame03");
    }
    public void Mini04SceneGo()
    {
        SceneManager.LoadScene("MiniGame04");
    }

    
}
