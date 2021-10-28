using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarNombresMapaFacultadCienciasSalud : MonoBehaviour
{
    public GameObject fondoLetras;
    public GameObject CarreraNombre;

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
        CarreraNombre.SetActive(true);
        yield return new WaitForSeconds(3);
        fondoLetras.SetActive(false);
        CarreraNombre.SetActive(false);
    }
}
