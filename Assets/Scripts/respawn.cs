using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    /*
    [SerializeField] private Transform Gracz;
    [SerializeField] private Transform respawnPoint;
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            /*
            Gracz.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            */
            // zostaje pobrana nazwa aktualnego poziomu i zostaje on wczytany jeszcze raz
            string nazwaPoziomu = Application.loadedLevelName;
            Application.LoadLevel(nazwaPoziomu);
        }
    }
}
