using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GameController")
        {
            GameManager.Instance.gameClear = true;
            GameManager.Instance.inGame = false;

        }   
    }


}
