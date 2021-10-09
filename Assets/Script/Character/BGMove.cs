using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{

    float speed = 24f;
    float timer = 0f;
    float time = 30f;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    public void Acceleraion(float addspeed) 
    {
        this.speed += addspeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-this.speed * Time.deltaTime, 0, 0);
        timer += Time.deltaTime;
        if(timer > time)
        {
            Destroy(this.gameObject);
        }

    }

}
