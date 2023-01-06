using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolec : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // zostaje pobrana nazwa aktualnego poziomu i zostaje on wczytany jeszcze raz
            string nazwaPoziomu = Application.loadedLevelName;
            Application.LoadLevel(nazwaPoziomu);
        }
    }
}
