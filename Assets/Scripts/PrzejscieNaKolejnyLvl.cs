using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrzejscieNaKolejnyLvl : MonoBehaviour
{
    public string nazwapoziomu;
    void OnCollisionEnter(Collision gameObjectInformaction)
    {
        if (gameObjectInformaction.gameObject.name == "Gracz")
        {
            Debug.Log("Collision Detected");
            SceneManager.LoadScene(nazwapoziomu);
        }
    }
}
