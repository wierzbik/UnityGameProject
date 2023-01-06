using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstPunkty : MonoBehaviour
{

    public Text punktytekst;
    void Update()
    {
        punktytekst.text = "  Kryształy: " + FindObjectOfType<Punkty>().wynik.ToString() + "/6";
    }
}
