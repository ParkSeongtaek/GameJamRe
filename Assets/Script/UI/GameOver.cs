using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static GameOver Instance;

    GameObject GameOverUI;

    private void Start()
    {
        Instance = this;
        GameOverUI = GameObject.Find("Canvas").transform.GetChild(0).gameObject;

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "GameController") { 
            Gameover();
        }
    }
    


   

    public void Gameover()
    {
        if (GameManager.Instance.inGame)
        {
            GameOverUI.SetActive(true);
            GameOverUI.GetComponent<GameOverUI>().SqnStart();
            GameManager.Instance.inGame = false;
            GameManager.Instance.gameOver = true;
        }
    }

}
