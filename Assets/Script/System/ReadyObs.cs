using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyObs : MonoBehaviour
{
    public GameObject ME;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GameController")
        {
            ME.GetComponent<AddForceDown>().useGravity();
        }
    }
}
