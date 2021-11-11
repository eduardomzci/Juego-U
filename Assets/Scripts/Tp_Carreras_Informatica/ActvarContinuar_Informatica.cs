using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ActvarContinuar_Informatica : MonoBehaviour
{
    public GameObject MenuPausa;

    public GameObject biomedica;
    public GameObject Electronica;
    public GameObject telecomunicaciones;
    public GameObject sistemasinformaticos;

    public string cambioEscenaCarreras = "informatica";
    public int carrera;

    public void Awake()
    {
        LoadData();
    }

    public void activarOpcionMenuPausa()
    {
        if (carrera == 0)
        {
            MenuPausa.SetActive(true);
            biomedica.SetActive(false);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(true);
            Electronica.SetActive(false);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(true);
            telecomunicaciones.SetActive(false);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(true);
            sistemasinformaticos.SetActive(false);
        }
        
    }

    public void activarContinuar()
    {
        if (carrera == 0)
        {
            MenuPausa.SetActive(false);
            biomedica.SetActive(true);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(false);
            Electronica.SetActive(true);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(false);
            telecomunicaciones.SetActive(true);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(false);
            sistemasinformaticos.SetActive(true);
        }
        
    }

    public void ActivarOpcionSalir()
    {
        SceneManager.LoadScene("MapaFacultadInformaticaElectronica");
    }

    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras, -1);
    }
}
