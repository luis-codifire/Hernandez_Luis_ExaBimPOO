using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaNasa : Item
{
    public override void Recoger()
    {
        Score.PuntuajeActual += 10;
        Debug.Log("nobre cosa" + objetoEspacial + "dato" + "mas datos NASA");
        Destroy(gameObject);
    }
}
