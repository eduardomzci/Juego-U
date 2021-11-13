using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorDeCarreras_Empresarial : MonoBehaviour
{
    public string cambioEscenaCarreras = "empresarial";
    public int carrera;


    public GameObject comercial;
    public GameObject empresas;
    public GameObject contaduria;
    public GameObject financiera;
    public GameObject comunicacion;
    public GameObject comerciointernacional;
    public GameObject psicologia;
    public GameObject juridicas;

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
            comercial.SetActive(true);
        }
        if (carrera == 1)
        {
            empresas.SetActive(true);
        }
        if (carrera == 2)
        {
            contaduria.SetActive(true);
        }
        if (carrera == 3)
        {
            financiera.SetActive(true);
        }
        if (carrera == 4)
        {
            comunicacion.SetActive(true);
        }
        if (carrera == 5)
        {
            comerciointernacional.SetActive(true);
        }
        if (carrera == 6)
        {
            psicologia.SetActive(true);
        }
        if (carrera == 7)
        {
            juridicas.SetActive(true);
        }
    }
    public void LoadData()
    {
        carrera = PlayerPrefs.GetInt(cambioEscenaCarreras, -1);
    }
}
