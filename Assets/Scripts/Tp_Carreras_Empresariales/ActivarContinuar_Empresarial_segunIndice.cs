using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ActivarContinuar_Empresarial_segunIndice : MonoBehaviour
{
    public GameObject MenuPausa;

    public GameObject comercial;
    public GameObject empresas;
    public GameObject contaduria;
    public GameObject financiera;
    public GameObject comunicacion;
    public GameObject comerciointernacional;
    public GameObject psicologia;
    public GameObject juridicas;

    public string cambioEscenaCarreras = "empresarial";
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
            comercial.SetActive(false);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(true);
            empresas.SetActive(false);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(true);
            contaduria.SetActive(false);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(true);
            financiera.SetActive(false);
        }
        if (carrera == 4)
        {
            MenuPausa.SetActive(true);
            comunicacion.SetActive(false);
        }
        if (carrera == 5)
        {
            MenuPausa.SetActive(true);
            comerciointernacional.SetActive(false);
        }
        if (carrera == 6)
        {
            MenuPausa.SetActive(true);
            psicologia.SetActive(false);
        }
        if (carrera == 7)
        {
            MenuPausa.SetActive(true);
            juridicas.SetActive(false);
        }
    }

    public void activarContinuar()
    {
        if (carrera == 0)
        {
            MenuPausa.SetActive(false);
            comercial.SetActive(true);
        }
        if (carrera == 1)
        {
            MenuPausa.SetActive(false);
            empresas.SetActive(true);
        }
        if (carrera == 2)
        {
            MenuPausa.SetActive(false);
            contaduria.SetActive(true);
        }
        if (carrera == 3)
        {
            MenuPausa.SetActive(false);
            financiera.SetActive(true);
        }
        if (carrera == 4)
        {
            MenuPausa.SetActive(false);
            comunicacion.SetActive(true);
        }
        if (carrera == 5)
        {
            MenuPausa.SetActive(false);
            comerciointernacional.SetActive(true);
        }
        if (carrera == 6)
        {
            MenuPausa.SetActive(false);
            psicologia.SetActive(true);
        }
        if (carrera == 7)
        {
            MenuPausa.SetActive(false);
            juridicas.SetActive(true);
        }
    }

    public void ActivarOpcionSalir()
    {
        //SceneManager.LoadScene("MapaFacultadSocialesEmpresariales");
        this.GetComponent<Canvas>().enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaFacultadSocialesEmpresariales"));
    }

    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras, -1);
    }
}
