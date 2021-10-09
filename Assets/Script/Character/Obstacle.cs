using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int obsNum = 4;
    public GameObject[] Obs = new GameObject[4]; //0.가시 1.새 2.사과 3. 뿌리;
    GameObject tmp;
    float standerd = 12f;
    float time ;
    float timer = 0f;
    bool set = false;
    int randnum;
    Vector3[] obgPos = new Vector3[4] ;
    
    // Start is called before the first frame update
    void Start()
    {
        obgPos[0] = new Vector3(75, -20, -2);
        obgPos[1] = new Vector3(75, -10, -2);
        obgPos[2] = new Vector3(90, 50, -2);
        obgPos[3] = new Vector3(75, -20, -2);

    }


    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.inGame) {
            if (!set)
            {
                time = Random.Range(standerd / (2 * GameManager.Instance.Stage + 2), standerd / (GameManager.Instance.Stage + 2));
                set = true;
            }
            timer += Time.deltaTime;
            if (timer > time)
            {
                Debug.Log("??");
                set = false;
                timer = 0f;
                randnum = Random.Range(0, obsNum);
                tmp = Instantiate(Obs[randnum], this.gameObject.transform);
                tmp.transform.position = obgPos[randnum];
                if(randnum == 2)
                {
                    tmp.GetComponent<BGMove>().Acceleraion(15f);
                }
                
                if(randnum == 3)
                {
                    Vector3 pos = tmp.transform.position;
                    pos += new Vector3(Random.Range(-20, 20), 0, 0);
                    tmp.transform.position = pos;
                }
            }

        }
    }
}
