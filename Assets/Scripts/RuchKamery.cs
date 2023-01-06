using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchKamery : MonoBehaviour
{
    public Transform gracz;
    void Update()
    {
        Vector3 vector = new Vector3(0, 10f, -10f); // vector o ktory przesuniemy kamere od gracza

        Vector3 nowaPozycjaKamery = gracz.position + vector;

        // płynne przechodzenie kamery
        transform.position = Vector3.Lerp(transform.position, nowaPozycjaKamery,Time.deltaTime*2f); // funkcja lerp przyjmuje 3 parametry (vector a polozenie początkowe  vector b położenie końcowe  wartosc 
        transform.LookAt(gracz);
    }
}
