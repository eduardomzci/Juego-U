using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ActivarContinuar_tecnologia_segunIndice : MonoBehaviour
{
    public GameObject MenuPausa;

    public GameObject aeronautica;
    public GameObject civil;
    public GameObject electronica;
    public GameObject Alimentaria;
    public GameObject Industrial;
    public GameObject Sistemas;
    public GameObject Mecanica;
    public GameObject PetroleoGas;
    public GameObject Petroquimica;

    public string cambioEscenaCarreras = "tecnologia";
    public int carrera;

    public LoadLevel ll;

    public void Awake()
    {
        LoadData();
    }

    public void activarOpcionMenuPausa()
    {
        if (carrera == 0)
        {
            MenuPausa.SetActive(true);
            aeronautica.SetActive(false);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(true);
            civil.SetActive(false);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(true);
            electronica.SetActive(false);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(true);
            Alimentaria.SetActive(false);
        }
        if (carrera == 4)
        {
            MenuPausa.SetActive(true);
            Industrial.SetActive(false);
        }
        if (carrera == 5)
        {
            MenuPausa.SetActive(true);
            Sistemas.SetActive(false);
        }
        if (carrera == 6)
        {
            MenuPausa.SetActive(true);
            Mecanica.SetActive(false);
        }
        if (carrera == 7)
        {
            MenuPausa.SetActive(true);
            PetroleoGas.SetActive(false);
        }
        if (carrera == 8)
        {
            MenuPausa.SetActive(true);
            Petroquimica.SetActive(false);
        }
    }

    public void activarContinuar()
    {
        if (carrera == 0)
        {
            MenuPausa.SetActive(false);
            aeronautica.SetActive(true);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(false);
            civil.SetActive(true);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(false);
            electronica.SetActive(true);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(false);
            Alimentaria.SetActive(true);
        }
        if (carrera == 4)
        {
            MenuPausa.SetActive(false);
            Industrial.SetActive(true);
        }
        if (carrera == 5)
        {
            MenuPausa.SetActive(false);
            Sistemas.SetActive(true);
        }
        if (carrera == 6)
        {
            MenuPausa.SetActive(false);
            Mecanica.SetActive(true);
        }
        if (carrera == 7)
        {
            MenuPausa.SetActive(false);
            PetroleoGas.SetActive(true);
        }
        if (carrera == 8)
        {
            MenuPausa.SetActive(false);
            Petroquimica.SetActive(true);
        }
    }

    public void ActivarOpcionSalir()
    {
        //SceneManager.LoadScene("MapaFacultadTecnologia");
        this.GetComponent<Canvas>().enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaFacultadTecnologia"));
    }

    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras, -1);
    }
}
