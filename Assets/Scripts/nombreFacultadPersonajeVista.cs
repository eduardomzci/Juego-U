using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nombreFacultadPersonajeVista : MonoBehaviour
{
    public GameObject fondoLetras;
    public GameObject facultadTecnologia;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(tiempoVisibilidad());
        }
    }

    public IEnumerator tiempoVisibilidad()
    {
        fondoLetras.SetActive(true);
        facultadTecnologia.SetActive(true);
        yield return new WaitForSeconds(3);
        fondoLetras.SetActive(false);
        facultadTecnologia.SetActive(false);
    }
}
