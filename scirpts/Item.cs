using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public string objetoEspacial = "sin nombre";

    public Score Score;

    public abstract void Recoger();

    private void Awake()
    {
        Collider collider = GetComponent<Collider>();
         if (collider != null )
        {
            collider.isTrigger = true;
        }
         else
        {
            Debug.Log("no se convirtio el colicionador en trigger o no tiene collider");
        }
    }
}
