using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portales : MonoBehaviour
{
    public LoadLevelScript ll;
    public GameObject salus;
    public GameObject empresarial;
    public GameObject arquitectura;
    public GameObject tecnologia;
    public GameObject informatica;
    public void Cambiar_Salus()
    {
        StartCoroutine(ll.LoadLevel1("MapaFacultadCienciasSalus"));
        salus.SetActive(false);
    }
    public void Cambiar_empresarial()
    {
        
        StartCoroutine(ll.LoadLevel1("MapaFacultadSocialesEmpresariales"));
        empresarial.SetActive(false);
    }
    public void Cambiar_arquitectura()
    {
        
        StartCoroutine(ll.LoadLevel1("MapaFacultadArquitecturaGastronomia"));
        arquitectura.SetActive(false);
    }
    public void Cambiar_tecnologia()
    {
        
        StartCoroutine(ll.LoadLevel1("MapaFacultadTecnologia"));
        tecnologia.SetActive(false);
    }
    public void Cambiar_informatica()
    {

        StartCoroutine(ll.LoadLevel1("MapaFacultadInformaticaElectronica"));
        informatica.SetActive(false);
    }
}
