using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public GameObject[] Luz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //en vez de buscar por etiqueta, buscas por tipo de componente heredado

        Item itemRecogido = other.GetComponent<Item>();

        if (itemRecogido != null)
        {
            itemRecogido.Recoger();
        }

        if (other.CompareTag("cosa interactiva"))
        {
            //Luz.SetActive(true);
            foreach (var Luz in Luz)
            {
                Luz.SetActive(true);
            }
            Debug.Log("inserte webada");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("cosa interactiva"))
        {
            foreach (var luzObj in Luz)
            {
                luzObj.SetActive(false);
            }
            Debug.Log("saquese prro");
        }
    }

}//puerta inferno
