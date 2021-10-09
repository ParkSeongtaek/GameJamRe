using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static GameOver Instance;

    private void Start()
    {
        Instance = this;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("닿았당");  
        if(col.name=="Enemy" || col.name == "Enemy1" || col.name == "Enemy2" || col.name == "Enemy3")
        {
            Gameover();
        }
    }


    //class OBJ{  OnSollisionEnter ( Collision = Char)   // Gameover. -> Gameover  }
    class Object
    {

    }

    public void Gameover()
    {
        Debug.Log("GAmeover");
    }

}
