using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FacultadActivarOpcionMenuPausa : MonoBehaviour
{
    public GameObject MenuPausa;
    public Canvas CanvasOpciones;
    public GameObject CanvasOpciones_OtrasFacultades;

    public GameObject Personaje;

    public LoadLevel ll;
    public Canvas c;
    public void ActivarOpcionMenuPausa()
    {
        MenuPausa.SetActive(true);
        CanvasOpciones.enabled=false;

        MovimientoPersonaje mp = Personaje.gameObject.GetComponent<MovimientoPersonaje>();
        Vector3 st = Personaje.gameObject.transform.position;
        NavMeshAgent ag = Personaje.gameObject.GetComponent<NavMeshAgent>();
        ag.SetDestination(st);
        mp.anim.SetBool("correr", false);
        mp.anim.SetBool("quieto", true);
        mp.enabled = false;
    }

    public void ActivarOpcionContinuar()
    {
        MenuPausa.SetActive(false);
        CanvasOpciones.enabled = true;
        CanvasOpciones_OtrasFacultades.SetActive(false);

        MovimientoPersonaje mp = Personaje.gameObject.GetComponent<MovimientoPersonaje>();
        Vector3 st = Personaje.gameObject.transform.position;
        mp.enabled = true;
    }

    public void ActivarOpcion_CancelarOtrosMapas()
    {
        MenuPausa.SetActive(true);
        CanvasOpciones.enabled = false;
        CanvasOpciones_OtrasFacultades.SetActive(false);
    }

    public void ActivarOpcion_OtrosMapas()
    {
        MenuPausa.SetActive(false);
        CanvasOpciones.enabled = false;
        CanvasOpciones_OtrasFacultades.SetActive(true);
    }

    public void ActivarOpcionSalir()
    {
        //SceneManager.LoadScene("MapaPrincipal");
        c.enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaPrincipal"));
    }


    public void Tp_Menu_Facultad_Tecnologia()
    {
        //SceneManager.LoadScene("MapaFacultadTecnologia");
        c.enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaFacultadTecnologia"));
    }
    public void Tp_Menu_Facultad_Informatica()
    {
        //SceneManager.LoadScene("MapaFacultadInformaticaElectronica");
        c.enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaFacultadInformaticaElectronica"));
    }
    public void Tp_Menu_Facultad_Arquitectura()
    {
        //SceneManager.LoadScene("MapaFacultadArquitecturaGastronomia");
        c.enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaFacultadArquitecturaGastronomia"));
    }
    public void Tp_Menu_Facultad_Empresarial()
    {
        //SceneManager.LoadScene("MapaFacultadSocialesEmpresariales");
        c.enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaFacultadSocialesEmpresariales"));
    }
    public void Tp_Menu_Facultad_Salus()
    {
        //SceneManager.LoadScene("MapaFacultadCienciasSalus");
        c.enabled = false;
        StartCoroutine(ll.LoadLevel1("MapaFacultadCienciasSalus"));
    }
}
