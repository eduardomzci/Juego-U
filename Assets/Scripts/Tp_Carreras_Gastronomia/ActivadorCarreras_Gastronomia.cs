using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorCarreras_Gastronomia : MonoBehaviour
{
    public string cambioEscenaCarreras = "gastronomia";
    public int carrera;


    public GameObject urbanismo;
    public GameObject interiores;
    public GameObject gastronomia;
    public GameObject turismo;

    public void Awake()
    {
        LoadData();
        if (carrera == 0)
        {
            urbanismo.SetActive(true);
        }
        if (carrera == 1)
        {
            interiores.SetActive(true);
        }
        if (carrera == 2)
        {
            gastronomia.SetActive(true);
        }
        if (carrera == 3)
        {
            turismo.SetActive(true);
        }
    }


    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras, -1);
    }
}
