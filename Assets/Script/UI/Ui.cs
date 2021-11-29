using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{
    public void Pause()
    {
        
    }
    public void GameOver()
    {

    }
    public void Re()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Park");
    }
   
}
