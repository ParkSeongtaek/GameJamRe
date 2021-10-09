using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceDown : MonoBehaviour
{
    public float force = 20f;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

   
}
