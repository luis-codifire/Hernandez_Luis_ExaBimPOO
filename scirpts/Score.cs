using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    //texto UI
    public TextMeshProUGUI textoPuntuaje;

    //variables internas
    private int puntosAstroanutas = 0;

    public Score(int puntosAstroanutas)
    {
        this.puntosAstroanutas = puntosAstroanutas;
    }

    public int PuntuajeActual { get; set; }

    void Start()
    {
        textoPuntuaje.text = "puntos astronauta: " + PuntuajeActual;
    }

    private void Update()
    {
        textoPuntuaje.text = "puntos astronauta: " + PuntuajeActual;
    }
}
