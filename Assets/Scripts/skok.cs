using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skok : MonoBehaviour
{
    public float silaSkoku = 5.0f;
    Rigidbody rb;
    private bool IsGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // kulka musi byc na ziemi
        if(Physics.Raycast(transform.position,-Vector3.up,0.501f))
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }

        if(Input.GetKeyDown(KeyCode.Space)&& IsGrounded)
        {
            rb.AddForce(0f,silaSkoku,0f);
        }
    }
}
