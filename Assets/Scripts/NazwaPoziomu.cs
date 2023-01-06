using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NazwaPoziomu : MonoBehaviour
{
    public TextMesh napisNazwyPoziomu;
    void Start()
    {
        string nazwaPoziomu = Application.loadedLevelName;
        napisNazwyPoziomu.text = nazwaPoziomu;
    }
}
