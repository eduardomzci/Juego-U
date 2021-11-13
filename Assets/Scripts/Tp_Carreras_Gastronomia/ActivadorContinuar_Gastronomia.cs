using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ActivadorContinuar_Gastronomia : MonoBehaviour
{
    public GameObject MenuPausa;

    public GameObject urbanismo;
    public GameObject interiores;
    public GameObject gastronomia;
    public GameObject turismo;

    public string cambioEscenaCarreras = "gastronomia";
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
            urbanismo.SetActive(false);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(true);
            interiores.SetActive(false);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(true);
            gastronomia.SetActive(false);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(true);
            turismo.SetActive(false);
        }

    }

    public void activarContinuar()
    {
        if (carrera == 0)
        {
            MenuPausa.SetActive(false);
            urbanismo.SetActive(true);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(false);
            interiores.SetActive(true);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(false);
            gastronomia.SetActive(true);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(false);
            turismo.SetActive(true);
        }

    }

    public void ActivarOpcionSalir()
    {
        //SceneManager.LoadScene("MapaFacultadArquitecturaGastronomia");
        this.GetComponent<Canvas>().enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaFacultadArquitecturaGastronomia"));
    }

    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras, -1);
    }
}
