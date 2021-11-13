using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ActivadorContinuar_Salus : MonoBehaviour
{
    public GameObject MenuPausa;

    public GameObject medicina;
    public GameObject odontologia;
    public GameObject farmacia;
    public GameObject enfermeria;
    public GameObject fisioterapia;

    public string cambioEscenaCarreras = "salus";
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
            medicina.SetActive(false);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(true);
            odontologia.SetActive(false);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(true);
            farmacia.SetActive(false);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(true);
            enfermeria.SetActive(false);
        }
        if (carrera == 4)
        {
            MenuPausa.SetActive(true);
            fisioterapia.SetActive(false);
        }

    }

    public void activarContinuar()
    {
        if (carrera == 0)
        {
            MenuPausa.SetActive(false);
            medicina.SetActive(true);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(false);
            odontologia.SetActive(true);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(false);
            farmacia.SetActive(true);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(false);
            enfermeria.SetActive(true);
        }
        if (carrera == 4)
        {
            MenuPausa.SetActive(false);
            fisioterapia.SetActive(true);
        }

    }

    public void ActivarOpcionSalir()
    {
        //SceneManager.LoadScene("MapaFacultadCienciasSalus");
        this.GetComponent<Canvas>().enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaFacultadCienciasSalus"));
    }

    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras, -1);
    }
}
