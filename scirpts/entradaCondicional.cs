using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entradaCondicional : MonoBehaviour
{
    public GameObject puerta;
    public Score marcador; // referencia a tu script de puntos

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (marcador.PuntuajeActual >= 10) // o condición que elijas
        {
            puerta.SetActive(false);
        }
    }
}
