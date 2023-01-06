using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class krysztal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            FindObjectOfType<Punkty>().wynik +=1;
            Destroy(gameObject);
        }
    }
}
