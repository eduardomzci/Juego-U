using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FacultadActivarOpcionMenuPausa : MonoBehaviour
{
    public GameObject MenuPausa;
    public GameObject CanvasOpciones;
    public GameObject CanvasOpciones_OtrasFacultades;

    public GameObject Personaje;
    public void ActivarOpcionMenuPausa()
    {
        MenuPausa.SetActive(true);
        CanvasOpciones.SetActive(false);

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
        CanvasOpciones.SetActive(true);
        CanvasOpciones_OtrasFacultades.SetActive(false);

        MovimientoPersonaje mp = Personaje.gameObject.GetComponent<MovimientoPersonaje>();
        Vector3 st = Personaje.gameObject.transform.position;
        mp.enabled = true;
    }

    public void ActivarOpcion_CancelarOtrosMapas()
    {
        MenuPausa.SetActive(true);
        CanvasOpciones.SetActive(false);
        CanvasOpciones_OtrasFacultades.SetActive(false);
    }

    public void ActivarOpcion_OtrosMapas()
    {
        MenuPausa.SetActive(false);
        CanvasOpciones.SetActive(false);
        CanvasOpciones_OtrasFacultades.SetActive(true);
    }

    public void ActivarOpcionSalir()
    {
        SceneManager.LoadScene("MapaPrincipal");
    }


    public void Tp_Menu_Facultad_Tecnologia()
    {
        SceneManager.LoadScene("MapaFacultadTecnologia");
    }
    public void Tp_Menu_Facultad_Informatica()
    {
        SceneManager.LoadScene("MapaFacultadInformaticaElectronica");
    }
    public void Tp_Menu_Facultad_Arquitectura()
    {
        SceneManager.LoadScene("MapaFacultadArquitecturaGastronomia");
    }
    public void Tp_Menu_Facultad_Empresarial()
    {
        SceneManager.LoadScene("MapaFacultadSocialesEmpresariales");
    }
    public void Tp_Menu_Facultad_Salus()
    {
        SceneManager.LoadScene("MapaFacultadCienciasSalus");
    }
}
