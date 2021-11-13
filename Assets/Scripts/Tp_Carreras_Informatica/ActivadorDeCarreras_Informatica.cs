using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorDeCarreras_Informatica : MonoBehaviour
{
    public string cambioEscenaCarreras = "informatica";
    public int carrera;


    public GameObject biomedica;
    public GameObject Electronica;
    public GameObject telecomunicaciones;
    public GameObject sistemasinformaticos;

    public void Awake()
    {
        LoadData();
        StartCoroutine(tiempoEspera());
    }

    public IEnumerator tiempoEspera()
    {
        yield return new WaitForSeconds(1.0f);
        if (carrera == 0)
        {
            biomedica.SetActive(true);
        }
        if (carrera == 1)
        {
            Electronica.SetActive(true);
        }
        if (carrera == 2)
        {
            telecomunicaciones.SetActive(true);
        }
        if (carrera == 3)
        {
            sistemasinformaticos.SetActive(true);
        }
    }

    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras, -1);
    }
}
