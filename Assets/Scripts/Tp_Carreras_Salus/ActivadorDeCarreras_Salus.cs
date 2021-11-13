using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorDeCarreras_Salus : MonoBehaviour
{
    public string cambioEscenaCarreras = "salus";
    public int carrera;


    public GameObject medicina;
    public GameObject odontologia;
    public GameObject farmacia;
    public GameObject enfermeria;
    public GameObject fisioterapia;

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
            medicina.SetActive(true);
        }
        if (carrera == 1)
        {
            odontologia.SetActive(true);
        }
        if (carrera == 2)
        {
            farmacia.SetActive(true);
        }
        if (carrera == 3)
        {
            enfermeria.SetActive(true);
        }
        if (carrera == 4)
        {
            fisioterapia.SetActive(true);
        }
    }
    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras, -1);
    }
}
