using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    //DB
    public bool inGame = true;
    public bool pause = false;
    public bool gameOver = false;
    public int Stage = 1;


    public void SetMaxScore(int score)
    {
        Stage = score;
    }
    public int GetMaxScore()
    {
        return Stage;
    }

    //Char state
    


    void Start()
    {


        Instance = this;
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(Instance);
        }
        Stage = PlayerPrefs.GetInt("Stage",1);


    }
    public void Save()
    {
        PlayerPrefs.SetInt("Stage", Stage);

    } 

}
