using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_EscenaChangue : MonoBehaviour
{
    public LoadLevel ll;
    public GameObject informatica;
    public GameObject arquitectura;
    public GameObject salus;
    public GameObject tecnologia;
    public GameObject empresarial;

    public void activar_informatica()
    {
        informatica.SetActive(false);
        StartCoroutine(ll.LoadLevel1("MapaFacultadInformaticaElectronica"));
        
    }
    public void activar_arquitectura()
    {
        arquitectura.SetActive(false);
        StartCoroutine(ll.LoadLevel1("MapaFacultadArquitecturaGastronomia"));
        
    }
    public void activar_salus()
    {
        salus.SetActive(false);
        StartCoroutine(ll.LoadLevel1("MapaFacultadCienciasSalus"));
    }
    public void activar_tecnologia()
    {
        tecnologia.SetActive(false);
        StartCoroutine(ll.LoadLevel1("MapaFacultadTecnologia"));
        
    }
    public void activar_empresarial()
    {
        empresarial.SetActive(false);
        StartCoroutine(ll.LoadLevel1("MapaFacultadSocialesEmpresariales"));
        
    }
}
