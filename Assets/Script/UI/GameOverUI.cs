using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverUI : MonoBehaviour
{
    Color color;
    Color tmp;

    float a = 0f;
    bool Sqn = false;
    // Start is called before the first frame update
    void Start()
    {
        color = this.GetComponent<Image>().color;

    }

    public void SqnStart()
    {
        tmp = this.GetComponent<Image>().color;
        tmp.a = 0f;
        this.GetComponent<Image>().color = tmp;

        color = tmp;
        Sqn = true;
        Debug.Log("??");
    }

    // Update is called once per frame
    void Update()
    {
        if (Sqn)
        {
            
            tmp.a +=0.01f ;
            color = tmp;
            this.GetComponent<Image>().color = color;

            Debug.Log("Why");
            if(color.a > 0.5f)
            {
                Sqn = false;
                Time.timeScale = 0f;
            }
        }
    }
}
