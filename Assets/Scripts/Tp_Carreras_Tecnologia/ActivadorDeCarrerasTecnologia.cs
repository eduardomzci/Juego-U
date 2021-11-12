using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorDeCarrerasTecnologia : MonoBehaviour
{
    public string cambioEscenaCarreras = "tecnologia";
    public int carrera;
    

    public GameObject aeronautica;
    public GameObject civil;
    public GameObject electronica;
    public GameObject Alimentaria;
    public GameObject Industrial;
    public GameObject Sistemas;
    public GameObject Mecanica;
    public GameObject PetroleoGas;
    public GameObject Petroquimica;

    public void Awake()
    {
        LoadData();
        if (carrera == 0)
        {
            aeronautica.SetActive(true);
        }
        if (carrera == 1)
        {
            civil.SetActive(true);
        }
        if (carrera == 2)
        {
            electronica.SetActive(true);
        }
        if (carrera == 3)
        {
            Alimentaria.SetActive(true);
        }
        if (carrera == 4)
        {
            Industrial.SetActive(true);
        }
        if (carrera == 5)
        {
            Sistemas.SetActive(true);
        }
        if (carrera == 6)
        {
            Mecanica.SetActive(true);
        }
        if (carrera == 7)
        {
            PetroleoGas.SetActive(true);
        }
        if (carrera == 8)
        {
            Petroquimica.SetActive(true);
        }

    }


    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras,-1);
    }
}
