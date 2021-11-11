using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FacultadActivarOpcionMenuPausa : MonoBehaviour
{
    public GameObject MenuPausa;
    public GameObject CanvasOpciones;

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

        MovimientoPersonaje mp = Personaje.gameObject.GetComponent<MovimientoPersonaje>();
        Vector3 st = Personaje.gameObject.transform.position;
        mp.enabled = true;
    }

    public void ActivarOpcionSalir()
    {
        SceneManager.LoadScene("MapaPrincipal");
    }
}
