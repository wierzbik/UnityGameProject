using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformyKlej : MonoBehaviour
{
    public GameObject gracz;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == gracz)
        {
            gracz.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == gracz)
        {
            gracz.transform.parent = null;
        }
    }
}
